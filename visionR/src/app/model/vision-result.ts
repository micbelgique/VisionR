import { Category } from './category';
import { Adult } from './adult';
import { Color } from './color';
import { ImageType } from './image-type';
import { Tag } from './tag';
import { Description } from './description';
import { Face } from './face';
import { Metadata } from './metadata';
import { Thing } from './thing';

export interface VisionResult {
    categories: Category[];
    adult: Adult;
    color: Color;
    imageType: ImageType;
    tags: Tag[];
    description: Description;
    faces: Face[];
    objects: Thing[];
    brands: any[];
    requestId: string;
    metadata: Metadata;
}
