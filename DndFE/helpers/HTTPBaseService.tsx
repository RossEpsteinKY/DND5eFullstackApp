import Axios, {AxiosInstance} from "axios";

export abstract class HTTPBaseService {
    protected instance: AxiosInstance;
    protected baseURL: string;

    public constructor() {
        this.baseURL = process.env.NEXT_PUBLIC_BASE_API_URL || '';
        this.instance = Axios.create({
            baseURL: this.baseURL,
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        });
    }
}
