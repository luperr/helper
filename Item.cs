using System;

namespace helper
{
 public class Item
    {
        public Item(string name, string rarity, string type, bool attunement, string description){
            Name = name;
            Rarity = rarity;
            Type = type;
            Attunement = attunement;
            Description = description;
        }
        public Item(string name, string rarity, string type, string description){
            Name = name;
            Rarity = rarity;
            Type = type;
            Attunement = false;
            Description = description;
        }

        public string Name {get; set;}
        private string Rarity {get; set;}
        private string Type {get; set;}
        private bool Attunement {get; set;}
        private string Description {get; set;}

        public void WriteItem(){
            Console.WriteLine("\n" 
            + "Item Name...............{0}\n" 
            + "Item Rarity.............{1}\n" 
            + "Item Type...............{2}\n" 
            + "Item Description........{3}\n",
            this.Name, this.Rarity, this.Type, this.Description);
        }

    }
}