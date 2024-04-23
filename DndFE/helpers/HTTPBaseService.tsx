import Axios, {AxiosError, AxiosInstance, AxiosRequestConfig} from "axios";

export abstract class HTTPBaseService {
    protected instance: AxiosInstance;
    token: string;
    protected baseURL: string;

    public constructor(token: string) {
        // set the baseURL from the env
        // todo: should this be dynamic to use with other APIs?
        this.baseURL = process.env.NEXT_PUBLIC_BASE_API_URL || '';
        // set the token
        this.token = token;
        // create the axios instance and store in protected var
        this.instance = Axios.create({
            baseURL: this.baseURL,
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        });

        this.initializeRequestInterceptor();
        this.initializeResponseInterceptor();
    }

    private initializeRequestInterceptor = () => {
        this.instance.interceptors.request.use( this.handleRequest );
    }

    private handleRequest = (config: AxiosRequestConfig) => {
        // @ts-ignore
        config.headers.authorization = `bearer ${this.token}`;
        return config;
    }

    private initializeResponseInterceptor = () => {
        this.instance.interceptors.response.use(response => {
            if (response.headers && response.headers.authorization) {
                const responseToken = (response.headers.authorization as string).split(' ')[1];
                this.token = responseToken;

                localStorage.setItem('hashToken', this.token);
            }
            return response;
        }, (error) => {
            return this.handleError(error);
        });
    }

    private handleError = async (error: AxiosError) => {
        const originalRequest = error.config;
        if(error.response?.status === 400) {
            console.log('HANDLERROR::400', error.response);
            return {
                //@ts-ignore
                message: error.response?.data.message,
                error: true
            }
        }
    }
}
