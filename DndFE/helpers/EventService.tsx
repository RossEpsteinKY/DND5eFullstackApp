/**import {HTTPBaseService} from "./HTTPBaseService";


export class EventService extends HTTPBaseService {
    private static classintance?:EventService;
    public static getInstance(token: string) {
        if( !this.classintance ) {
            this.classintance = new EventService(token);
        }
        this.classintance.token = token;

        return this.classintance;
    }
    public getEvents = () => {

        let apiKey = process.env.REACT_APP_CALENDAR_API_KEY;
        const currentDate = new Date().toISOString();

        return fetch('https://www.googleapis.com/calendar/v3/calendars/vcjolj9j5oq560bp0mtgqi0jio%40group.calendar.google.com/events?' +
            'orderBy=startTime&singleEvents=true&timeMin='
            + currentDate +
            '&showDeleted=false&key=' + apiKey)
            .then(response => {
                // @ts-ignore
                return response?.json() || response?.redirect || {};
            });
    }

}
**/