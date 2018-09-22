import { Animal } from "./Animal";


export class Dog extends Animal
{
    Name: string;
   
    constructor()
    {
        super();
        this.Name="Puppy";
    }
}