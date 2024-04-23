import Axios, {AxiosRequestConfig} from "axios";

let urls = {
    test: 'http://localhost:9000',
    development: process.env.NEXT_PUBLIC_BASE_API_URL
};

const api = Axios.create({
    // baseURL: urls[process.env.NODE_ENV],
    baseURL: process.env.NEXT_PUBLIC_BASE_API_URL,
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
});

api.interceptors.response.use(
    (response) => response,
    (error) => {
        if(error && error.response && error.response.data && error.response.data.statusCode === 401) {
            console.log('AXIOS GLOBAL ERROR', error.response.data);
        }

        throw error;
    }
)

// console.log('API', api);
export default api