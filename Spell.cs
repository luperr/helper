using System;

namespace helper
{
    public class Spell
    {
        public Spell(){
            Name = "NULL";
        }
        
        public Spell(string name, string school, string class, string description){
            Name = name;
            School = school;
            Class = class;
            Description = description;
            Level = 2;
        }
        
        

        public string Name {get; set;}
        public string School {get; set;}
        public string Class {get; set;}
        public string Description {get; set;}
        public int Level {get; set;}

        public void WriteSpell(){
            Console.WriteLine("\n"
            + "Spell name...........{0}\n"
            + "School of Magic......{1}\n"
            + "User class...........{2}\n"
            + "Spell Level..........{3}\n"
            + "Description..........{4}\n",
            this.Name, this.School, this.Class, this.Level, this.Description);
        }
    }
}