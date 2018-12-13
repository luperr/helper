using System;

namespace helper
{   
    class Program
    {
        static void Main(string[] args)
        {
            Item newItem = new Item("test Item", "rare", "armour", "A very special armour thingy");
            //Spell newSpell = new Spell("test spell", "necro", "Cleric", "a coooool spell", 3);

            Spell newSpellBlank = new Spell();


            newItem.WriteItem();
            //newSpell.WriteSpell();
            string test = newSpellBlank.Name;
            Console.WriteLine(test);
        }
    }
}
