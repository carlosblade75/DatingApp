import { IPhoto } from './IPhoto';

export interface IUser {
    age: number;
    city: string;
    country: string;
    created: Date;
    gender: string;
    id: number;
    knowAs: string;
    lastActive: Date;
    photoUrl: string;
    username: string;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: IPhoto[];
}
