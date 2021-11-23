using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GrammarsConverter
{
    private static readonly Dictionary<string, List<string>> grammarDict = new Dictionary<string, List<string>>
    {

        {"/building",
         new List<string>{ "Mill", "Library", "Jeweler", "Town Hall", "Tavern", "Temple", "Stables", "Guardhouse",
             "Blacksmith", "Tailorshop", "Alchemist's Shop", "Lighthouse", "Pier", "Theater", "Monument", "Spice Shop",
             "Brothel", "Inn", "Church", "Shrine", "Hunter's Camp", "Weaponsmith", "Carpenter Hut", "Potter's Workshop",
             "Brewery", "Mason's House", "Vineyard", "Apple Orchard", "Great Hall", "Granary", "Cattle Barn", "Fishery",
             "Charcoal Maker Cottage", "Furrier" } },

        {"/noun1",
        new List<string>{ "Thunder", "Hail", "Actor", "Afternoon", "Animal", "Answer", "Apple", "Army", "Balloon",
            "Banana", "Beach", "Beard", "Bed", "Branch", "Breakfast", "Brother", "Candle", "Caravan", "Carpet", 
            "Church", "Crowd", "Daughter", "Death", "Diamond", "Dinner", "Disease", "Doctor", "Dog", "Dream", "Dress",
            "Egg", "Elephant", "Energy", "Evening", "Eye", "Family", "Fish", "Flag", "Flower", "Forest", "Fountain", 
            "Gold", "Grass", "Hair", "Helm", "Honey", "Horse", "House", "Ice", "Iron", "Island", "Jackal", "Jelly",
            "Jewellery", "Juice", "King", "Knife", "Leather", "Lion", "Lizard", "Lock", "Lunch", "Market", "Match",
            "Morning", "Nail", "Needle", "Nest", "Ocean", "Orange", "Oyster", "Ghost", "Painting", "Parrot", "Queen",
            "Quill", "Rain", "River", "Rose", "Shoe", "Stone", "Sugar", "Tent", "Tomato", "Vase", "Vegetable", "Wall",
            "Whale", "Yak", "Garden", "Castle", "Moat", "Tower", "Snake", "Sickle", "Club", "Dagger", "Handaxe",
            "Javelin", "Mace", "Staff", "Spear", "Crossbow", "Dart", "Sling", "BattleAxe", "Flail", "Glaive",
            "Greatsword", "Halberd", "Lance", "Maul", "Pike", "Scimitar", "Trident", "Whip", "Net", "Vial", "Amulet",
            "Bell", "Basket", "Barrel", "Bucket", "Bottle", "Cart", "Carriage", "Hut", "World", "Person", "Group",
            "Hawk", "Swamp", "Sea", "Map", "Food", "Music", "Power", "Knowledge", "Love", "Ability", "Nature", "Society",
            "History", "System", "Equipment", "Freedom", "Attention", "Wood", "Tree", "Grass", "Currency", "Book",
            "Table", "Water", "Rug", "Money", "Soul", "Cup", "Bush", "Cactus", "Banner", "Cloak", "Cape", "Ring", "Paper",
            "Spoon", "Fork", "Chair", "Ale", "Field", "Farm", "Mud", "Dirt", "Soil", "Cow", "Chicken", "Bear", "Pig",
            "Flour", "Shop", "Cattle", "Grain", "Cider", "Peasant", "Serf", "Black Death", "Hearth", "Cauldron",
            "Chimney", "Firepit", "Forge", "Brazier", "Corn" } },

        {"/noun2",
        new List<string>{ "Thunder", "Hail", "Actor", "Afternoon", "Animal", "Answer", "Apple", "Army", "Balloon",
            "Banana", "Beach", "Beard", "Bed", "Branch", "Breakfast", "Brother", "Candle", "Caravan", "Carpet",
            "Church", "Crowd", "Daughter", "Death", "Diamond", "Dinner", "Disease", "Doctor", "Dog", "Dream", "Dress",
            "Egg", "Elephant", "Energy", "Evening", "Eye", "Family", "Fish", "Flag", "Flower", "Forest", "Fountain",
            "Gold", "Grass", "Hair", "Helm", "Honey", "Horse", "House", "Ice", "Iron", "Island", "Jackal", "Jelly",
            "Jewellery", "Juice", "King", "Knife", "Leather", "Lion", "Lizard", "Lock", "Lunch", "Market", "Match",
            "Morning", "Nail", "Needle", "Nest", "Ocean", "Orange", "Oyster", "Ghost", "Painting", "Parrot", "Queen",
            "Quill", "Rain", "River", "Rose", "Shoe", "Stone", "Sugar", "Tent", "Tomato", "Vase", "Vegetable", "Wall",
            "Whale", "Yak", "Garden", "Castle", "Moat", "Tower", "Snake", "Sickle", "Club", "Dagger", "Handaxe",
            "Javelin", "Mace", "Staff", "Spear", "Crossbow", "Dart", "Sling", "BattleAxe", "Flail", "Glaive",
            "Greatsword", "Halberd", "Lance", "Maul", "Pike", "Scimitar", "Trident", "Whip", "Net", "Vial", "Amulet",
            "Bell", "Basket", "Barrel", "Bucket", "Bottle", "Cart", "Carriage", "Hut", "World", "Person", "Group",
            "Hawk", "Swamp", "Sea", "Map", "Food", "Music", "Power", "Knowledge", "Love", "Ability", "Nature", "Society",
            "History", "System", "Equipment", "Freedom", "Attention", "Wood", "Tree", "Grass", "Currency", "Book",
            "Table", "Water", "Rug", "Money", "Soul", "Cup", "Bush", "Cactus", "Banner", "Cloak", "Cape", "Ring", "Paper",
            "Spoon", "Fork", "Chair", "Ale", "Field", "Farm", "Mud", "Dirt", "Soil", "Cow", "Chicken", "Bear", "Pig",
            "Flour", "Shop", "Cattle", "Grain", "Cider", "Peasant", "Serf", "Black Death", "Hearth", "Cauldron",
            "Chimney", "Firepit", "Forge", "Brazier", "Corn" } },

        {"/possesivepronoun",
        new List<string>{ "My", "Our", "Your", "His" , "Her" , "Their" } },

        {"/personalpronouns",
        new List<string>{ "I", "We", "You", "He" , "She" , "They" } },

        {"/verb",
        new List<string>{ "Accept", "Add", "Admire", "Admit", "Advise", "Afford", "Agree", "Alert", "Allow", "Bake",
            "Balance", "Ban", "Battle", "Beg", "Behave", "Bomb", "Bounce", "Burn", "Brush", "Buzz", "Bury", "Calculate",
            "Call", "Camp", "Care", "Carve", "Challenge", "Change", "Chase", "Cheat", "Cheer", "Choke", "Chop", "Coil",
            "Damage", "Dance", "Dare", "Decay", "Deceive", "Decorate", "Delay", "Delight", "Deliver", "Depend", "Drip",
            "Earn", "Educate", "Employ", "Empty", "Encourage", "End", "Enjoy", "Excite", "Explain", "Explode", "Entertain",
            "Face", "Fade", "Fasten", "Fear", "Fetch", "File", "Fill", "Fix", "Flash", "Flood", "Flow", "Fool", "Force",
            "Gather", "Gaze", "Glow", "Glue", "Grab", "Grate", "Grin", "Grip", "Guard", "Guess", "Guide", "Greet",
            "Hammer", "Hand", "Haunt", "Heal", "Heat", "Help", "Hook", "Hop", "Hope", "Hover", "Hug", "Hum", "Hunt", "Hurry",
            "Identify", "Ignore", "Imagine", "Impress", "Improve", "Include", "Increase", "Inform", "Interfere", "Introduce",
            "Jam", "Jog", "Join", "Joke", "Judge", "Juggle", "Jump", "Kick", "Kneel", "Knit", "Knock", "Knot", "Label",
            "Laugh", "Launch", "Learn", "Lie", "Listen", "Live", "Lock", "Look", "Manage", "Mark", "March", "Measure", "Mix",
            "Moor", "Muddle", "Need", "Node", "Notice", "Obey", "Observe", "Obtain", "Offend", "Order", "Open", "Pack",
            "Paddle", "Paint", "Park", "Pass", "Pat", "Pause", "Pick", "Plant", "Pray", "Preach", "Post", "Produce", 
            "Question", "Race", "Radiate", "Raise", "Reach", "Remove", "Repair", "Replace", "Rescue", "Rush", "Sail",
            "Save", "Scatter", "Seal", "Shelter", "Shock", "Stamp", "Surround", "Talk", "Tame", "Tap", "Thaw", "Trust",
            "Use", "Unlock", "Walk", "Wander", "Warm", "Wave", "Whistle", "Wrap", "Yawn", "Yell", "Zoom"} },

        {"/adjective",
        new List<string>{ "Elementary", "Private", "Different", "Medieval", "Complete", "Imaginary", "Happy", "Newfound",
            "Distant", "Personal", "Particular", "Weird", "Standard", "Inner", "Dazzling", "Compelling", "Derivative", 
            "Coherent", "Macho", "Sick", "Simplistic", "Fat", "Woodland", "Vivid", "Lush", "Fascinating", "Rich", 
            "Beleaguered", "Fake", "Complex", "Crazy", "Believable", "Recongnizable", "Usual", "Classic", "Amazing", "Urban",
            "Dark", "Satisfying", "Adorable", "Adventurous", "Aggressive", "Agreeable", "Alert", "Alive", "Amused", "Angry",
            "Annoyed", "Anxious", "Arrogant", "Attractive", "Average", "Bad", "Beautiful", "Better", "Bloody", "Brainy",
            "Brave", "Bright", "Calm", "Careful", "Charming", "Clear", "Clever", "Colorful", "Combative", "Crazy",
            "Curious", "Cute", "Defiant", "Fast", "Slow", "Quick", "Low", "High", "Major", "Small", "Fluffy"} }

    };

    public static string Convert(string inputText)
    {
        foreach (var key in grammarDict.Keys)
        {
            if (inputText.Contains(key))
            {
                int random = Random.Range(0, grammarDict[key].Count);
                inputText = inputText.Replace(key, grammarDict[key][random]);
            }
        }
        return inputText;
    }


}
