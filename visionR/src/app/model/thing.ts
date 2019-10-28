import { Rectangle } from './rectangle';

export interface Thing {
    rectangle: Rectangle;
    object: string;
    confidence: number;
}
