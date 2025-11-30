using System.Collections.Generic;

public static class QuestionDatabase
{
    public static Dictionary<CategoryType, List<QuestionData>> BuildQuestionBank()
    {
        var questionBank = new Dictionary<CategoryType, List<QuestionData>>();

        var got = new List<QuestionData>
{
    // --------------------------------------------------------
    // GAME OF THRONES – EASY (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "What is the name of Jon Snow's direwolf?",
        answers = new[] { "Ghost", "Nymeria", "Summer", "Grey Wind" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is known as the Mother of Dragons?",
        answers = new[] { "Cersei Lannister", "Sansa Stark", "Daenerys Targaryen", "Yara Greyjoy" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the capital of the Seven Kingdoms?",
        answers = new[] { "Casterly Rock", "Oldtown", "Winterfell", "King's Landing" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who pushes Bran Stark out of the window in Season 1?",
        answers = new[] { "Cersei Lannister", "Jaime Lannister", "Littlefinger", "The Hound" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What metal can kill White Walkers?",
        answers = new[] { "Gold", "Valyrian Steel", "Bronze", "Copper" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which house's words are 'Winter is Coming'?",
        answers = new[] { "House Lannister", "House Baratheon", "House Stark", "House Greyjoy" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of Arya Stark's small sword?",
        answers = new[] { "Ice", "Oathkeeper", "Needle", "Longclaw" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the dwarf Lannister?",
        answers = new[] { "Tywin", "Jaime", "Tyrion", "Lancel" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What huge structure separates the North from the lands beyond?",
        answers = new[] { "The Wall", "The Trident", "The Dreadfort", "The Twins" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which house has a lion as its sigil?",
        answers = new[] { "House Stark", "House Tully", "House Lannister", "House Tyrell" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the Lord of Winterfell at the beginning of the series?",
        answers = new[] { "Robb Stark", "Ned Stark", "Benjen Stark", "Bran Stark" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What are the undead enemies from beyond the Wall called?",
        answers = new[] { "Wargs", "Wildlings", "White Walkers", "Giants" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which house's sigil is a kraken?",
        answers = new[] { "House Tyrell", "House Arryn", "House Greyjoy", "House Martell" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of Daenerys’s largest dragon?",
        answers = new[] { "Rhaegal", "Drogon", "Viserion", "Balerion" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which city does the Iron Bank reside in?",
        answers = new[] { "Braavos", "Meereen", "Volantis", "Pentos" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the continent where most of the story takes place?",
        answers = new[] { "Essos", "Westeros", "Sothoryos", "Valyria" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is Sansa’s younger sister?",
        answers = new[] { "Margaery", "Lyanna", "Arya", "Ygritte" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which character is known as 'The Hound'?",
        answers = new[] { "Sandor Clegane", "Gregor Clegane", "Bronn", "Podrick Payne" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the surname given to bastards in the North?",
        answers = new[] { "Snow", "Rivers", "Sand", "Storm" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the main religion followed in King’s Landing?",
        answers = new[] { "The Lord of Light", "The Old Gods", "The Faith of the Seven", "The Drowned God" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },

new QuestionData
{
    questionText = "What color is Daenerys Targaryen’s hair?",
    answers = new[] { "Black", "Blonde", "Silver/White", "Brown" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the surname given to bastards in Dorne?",
    answers = new[] { "Sand", "Snow", "Rivers", "Hill" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which family is known for saying 'A Lannister always pays his debts'?",
    answers = new[] { "Stark", "Baratheon", "Greyjoy", "Lannister" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the first name of the eldest Stark daughter?",
    answers = new[] { "Arya", "Sansa", "Lyanna", "Catelyn" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which animal represents House Stark?",
    answers = new[] { "Dragon", "Lion", "Stag", "Direwolf" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the youngest Stark child?",
    answers = new[] { "Rodrik", "Rickon", "Bran", "Benjen" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the father of Joffrey Baratheon?",
    answers = new[] { "Stannis Baratheon", "Robert Baratheon", "Jaime Lannister", "Renly Baratheon" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which religion uses the phrase 'Valar Morghulis'?",
    answers = new[] { "Faith of the Seven", "Old Gods", "Many-Faced God", "Drowned God" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Bran Stark’s direwolf?",
    answers = new[] { "Nymeria", "Summer", "Shaggydog", "Lady" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Stark child is known for warging?",
    answers = new[] { "Robb", "Arya", "Bran", "Sansa" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What title does the ruler of the Iron Islands hold?",
    answers = new[] { "King of Salt and Rock", "Lord Reaper", "High Septon", "Hand of the King" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is Robb Stark’s mother?",
    answers = new[] { "Cersei", "Catelyn", "Brienne", "Lyanna" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is Daenerys’s older brother?",
    answers = new[] { "Viserys", "Rhaegar", "Aegon", "Baelor" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which house lives at Dragonstone?",
    answers = new[] { "Lannister", "Baratheon", "Targaryen", "Greyjoy" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which city is known for training Unsullied soldiers?",
    answers = new[] { "Qarth", "Volantis", "Astapor", "Braavos" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What material are the dragonglass weapons made from?",
    answers = new[] { "Obsidian", "Steel", "Bronze", "Gold" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the queen of Westeros at the very beginning of Season 1?",
    answers = new[] { "Cersei Lannister", "Daenerys Targaryen", "Margaery Tyrell", "Lyanna Stark" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who raises Jon Snow at Winterfell?",
    answers = new[] { "Catelyn Stark", "Ned Stark", "Benjen Stark", "Robb Stark" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which title is held by the ruler on the Iron Throne?",
    answers = new[] { "King of the Free Cities", "King of Winter", "King of the Andals, the Rhoynar, and the First Men", "High Septon" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Lannister is known as the Kingslayer?",
    answers = new[] { "Tywin", "Jaime", "Tyrion", "Kevan" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the red-haired daughter of House Stark?",
    answers = new[] { "Sansa", "Arya", "Lyanna", "Catelyn" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is Samwell Tarly’s nickname?",
    answers = new[] { "Sam the Strong", "Sam the Quick", "Sam the Brave", "Sam the Slow" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which character says 'You know nothing, Jon Snow'?",
    answers = new[] { "Arya Stark", "Ygritte", "Melisandre", "Sansa Stark" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Lannister is known for drinking and being witty?",
    answers = new[] { "Tywin", "Jaime", "Tyrion", "Joffrey" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Joffrey Baratheon’s mother?",
    answers = new[] { "Margaery", "Cersei", "Myrcella", "Selyse" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What do the Dothraki ride into battle?",
    answers = new[] { "Camels", "Horses", "Direwolves", "Elephants" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Robb Stark’s direwolf?",
    answers = new[] { "Grey Wind", "Lady", "Shaggydog", "Ghost" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who serves as Hand of the King to Robert Baratheon at the start of the show?",
    answers = new[] { "Tyrion Lannister", "Ned Stark", "Stannis Baratheon", "Jon Arryn" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Where is the Night’s Watch located?",
    answers = new[] { "The Eyrie", "Castle Black", "Dragonstone", "Oldtown" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Catelyn Stark’s father’s house?",
    answers = new[] { "House Arryn", "House Martell", "House Tully", "House Frey" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},



    // --------------------------------------------------------
    // GAME OF THRONES – MEDIUM (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "What is the ancestral sword of House Stark before it was melted down?",
        answers = new[] { "Ice", "Oathkeeper", "Widow’s Wail", "Longclaw" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who kills Stannis Baratheon in the show?",
        answers = new[] { "Brienne of Tarth", "Jon Snow", "Ramsay Bolton", "Theon Greyjoy" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the sigil of House Tully?",
        answers = new[] { "A trout", "A kraken", "A sun", "A stag" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which continent lies east of Westeros?",
        answers = new[] { "Essos", "Ulthos", "Sothoryos", "Naath" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who is Sandor Clegane’s brother?",
        answers = new[] { "Gregor Clegane", "Loras Tyrell", "Barristan Selmy", "Jorah Mormont" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Arya’s sword trainer from Braavos?",
        answers = new[] { "Syrio Forel", "Daario Naharis", "Jaqen H’ghar", "Salladhor Saan" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is Melisandre's common title?",
        answers = new[] { "The Red Woman", "The Whispering Lady", "The Pale Shadow", "The Oracle" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who rules the Iron Islands before Euron Greyjoy?",
        answers = new[] { "Balon Greyjoy", "Victarion Greyjoy", "Asha/Yara Greyjoy", "Rodrik Harlaw" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who created the Night King in the HBO show?",
        answers = new[] { "Children of the Forest", "First Men", "Valyrians", "Targaryens" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the official motto of House Lannister?",
        answers = new[] { "Hear Me Roar!", "A Lannister Always Pays His Debts", "Lion’s Pride", "Gold and Glory" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who is the Lord Commander of the Night’s Watch when Jon Snow first arrives at Castle Black?",
        answers = new[] { "Jeor Mormont", "Alliser Thorne", "Eddison Tollett", "Qhorin Halfhand" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In which city does Daenerys first earn the title 'Breaker of Chains'?",
        answers = new[] { "Meereen", "Astapor", "Yunkai", "Qarth" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who was betrothed to Joffrey before Sansa?",
        answers = new[] { "Margaery Tyrell", "Lyanna Stark", "Arianne Martell", "No one" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the castle held by House Frey?",
        answers = new[] { "Riverrun", "The Twins", "Harrenhal", "Pyke" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who is known as 'The Kingslayer'?",
        answers = new[] { "Ned Stark", "Jaime Lannister", "Bronn", "Barristan Selmy" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which house’s words are 'Fire and Blood'?",
        answers = new[] { "House Baratheon", "House Martell", "House Targaryen", "House Tyrell" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the capital of the Reach?",
        answers = new[] { "Highgarden", "Oldtown", "Riverrun", "Sunspear" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which group worships the Lord of Light?",
        answers = new[] { "Sons of the Harpy", "Dothraki", "Faith Militant", "Followers of R’hllor" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What poison is used to kill King Joffrey?",
        answers = new[] { "Tears of Lys", "The Strangler", "Basilisk Blood", "Widow’s Blood" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who trains Arya in the House of Black and White?",
        answers = new[] { "Syrio Forel", "Jaqen H’ghar", "Daario Naharis", "Thoros of Myr" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },

new QuestionData
{
    questionText = "Who becomes the Lord of the Eyrie after Lysa Arryn’s death?",
    answers = new[] { "Robin Arryn", "Petyr Baelish", "Nestor Royce", "Yohn Royce" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Brienne of Tarth’s ancestral home?",
    answers = new[] { "Tarth", "Storm’s End", "Dragonstone", "Evenfall Hall" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which sellsword company does Jorah Mormont once belong to?",
    answers = new[] { "Second Sons", "Golden Company", "Stormcrows", "Windblown" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the Stark family’s ancestral greatsword?",
    answers = new[] { "Ice", "Needle", "Longclaw", "Heartsbane" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who leads the Brotherhood Without Banners?",
    answers = new[] { "Beric Dondarrion", "Sandor Clegane", "Gendry", "Thoros of Myr" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What does the High Sparrow call his religious military order?",
    answers = new[] { "Faithful Swords", "Sparrows", "Faith Militant", "Holy Blades" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which city is ruled by the Great Masters before Daenerys conquers it?",
    answers = new[] { "Astapor", "Yunkai", "Meereen", "Qarth" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is Gendry’s skill before joining the Brotherhood?",
    answers = new[] { "Blacksmithing", "Sailing", "Farming", "Hunting" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the sword Jon Snow receives from Jeor Mormont?",
    answers = new[] { "Ice", "Longclaw", "Widow’s Wail", "Oathkeeper" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which Lannister commands the forces at the Battle of Blackwater?",
    answers = new[] { "Tyrion Lannister", "Tywin Lannister", "Jaime Lannister", "Kevan Lannister" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What title does Robb Stark take during the War of the Five Kings?",
    answers = new[] { "Lord of Winterfell", "King in the North", "Warden of the North", "Protector of the Realm" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who does Brienne of Tarth swear an oath to protect?",
    answers = new[] { "Daenerys", "Margaery", "Catelyn Stark", "Arya Stark" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is known as the 'Three-Eyed Raven'?",
    answers = new[] { "Bloodraven", "Jojen Reed", "Bran Stark", "Loras Tyrell" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What group is responsible for killing Jon Arryn?",
    answers = new[] { "Lannisters", "Littlefinger and Lysa Arryn", "Starks", "Targaryens" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the ancestral seat of House Tyrell?",
    answers = new[] { "Sunspear", "The Arbor", "Highgarden", "Casterly Rock" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which Stark child becomes a Faceless Man apprentice?",
    answers = new[] { "Arya", "Sansa", "Bran", "Robb" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Cersei’s daughter?",
    answers = new[] { "Myranda", "Myrcella", "Joanna", "Margaery" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who kills Tywin Lannister?",
    answers = new[] { "Jaime", "Arya", "Oberyn", "Tyrion" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which group raids the countryside wearing flayed man sigils?",
    answers = new[] { "The Lannisters", "The Ironborn", "The Boltons", "The Brotherhood" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the commander of the City Watch (Gold Cloaks) early in the series?",
    answers = new[] { "Bronn", "Janos Slynt", "The Hound", "Pycelle" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "In which castle is Bran when he falls from the tower?",
    answers = new[] { "Riverrun", "Casterly Rock", "Winterfell", "The Eyrie" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which Ironborn becomes Queen of the Iron Islands for a short time?",
    answers = new[] { "Asha/Yara Greyjoy", "Cersei Lannister", "Ellaria Sand", "Melisandre" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which Stark is the first to reunite with Jon Snow after his death?",
    answers = new[] { "Arya", "Sansa", "Bran", "Rickon" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who kills Ramsay Bolton?",
    answers = new[] { "Theon", "Jon Snow", "Sansa Stark", "Brienne" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the Iron Bank’s motto?",
    answers = new[] { "We Demand Payment", "The Iron Throne is Ours", "We Do Not Forget", "The Debt Must Be Paid" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who forms an alliance with Daenerys in Season 7 by marriage proposal?",
    answers = new[] { "Tyrion", "Jon Snow", "Daario", "Euron Greyjoy" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What do the Dothraki call Daenerys?",
    answers = new[] { "Khalessi", "Mhysa", "Breaker of Chains", "The Dragon" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Where does Arya kill Walder Frey?",
    answers = new[] { "Riverrun", "The Twins", "Winterfell", "Kings Landing" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who resurrects Jon Snow?",
    answers = new[] { "Thoros of Myr", "Melisandre", "The Three-Eyed Raven", "Bran Stark" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What castle is known as the 'Seat of the King in the North'?",
    answers = new[] { "Winterfell", "White Harbor", "Moat Cailin", "The Dreadfort" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},


    // --------------------------------------------------------
    // GAME OF THRONES – HARD (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Who was the last Targaryen king before Robert’s Rebellion?",
        answers = new[] { "Aerys II", "Aegon V", "Jaehaerys II", "Aenys I" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dragonglass is another name for what real-world volcanic material?",
        answers = new[] { "Obsidian", "Quartz", "Moonstone", "Jet" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which city is known as the 'Queen of Cities' in Essos?",
        answers = new[] { "Volantis", "Meereen", "Braavos", "Old Valyria" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is Jon Snow's real birth name in the show?",
        answers = new[] { "Aegon Targaryen", "Aemon Targaryen", "Baelor Targaryen", "Daeron Targaryen" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Pycelle belongs to which order?",
        answers = new[] { "The Maesters", "The Children of the Forest", "The Priests of R’hllor", "The Faceless Men" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which house rules Dorne from Sunspear?",
        answers = new[] { "House Martell", "House Dayne", "House Yronwood", "House Fowler" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who leads the Golden Company at the end of the show?",
        answers = new[] { "Harry Strickland", "Myles Toyne", "Caggo Corpsekiller", "Black Balaq" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What caused the Doom of Valyria?",
        answers = new[] { "Volcanic eruptions", "War", "Plague", "Dragons turning on their riders" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which of these languages is spoken by the children of the Forest?",
        answers = new[] { "The Old Tongue", "High Valyrian", "The True Tongue", "They speak in their own rustling language" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Valyrian steel sword that becomes Brienne's Oathkeeper?",
        answers = new[] { "Ice reforged", "Blackfyre", "Heartsbane", "Dark Sister" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Targaryen prince did Lyanna Stark allegedly love?",
        answers = new[] { "Rhaegar", "Aegon", "Maegor", "Viserys" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the wildfire cache used to destroy the Great Sept of Baelor?",
        answers = new[] { "Dragonfire", "Septon’s Wrath", "Wildfire", "King’s Breath" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who originally wielded the sword Heartsbane?",
        answers = new[] { "Randall Tarly", "Samwell Tarly", "Jorah Mormont", "Barristan Selmy" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which god do the Faceless Men worship?",
        answers = new[] { "The Many-Faced God", "The Drowned God", "The Lord of Light", "The Stranger" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the ancient fortress at the northern end of the Wall where the Night’s Watch headquarters is located?",
        answers = new[] { "Eastwatch", "Castle Black", "Shadow Tower", "The Nightfort" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Targaryen king built the Red Keep?",
        answers = new[] { "Aegon I", "Maegor I", "Jaehaerys I", "Aenys I" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who commands the Unsullied at the beginning of the series?",
        answers = new[] { "Grey Worm", "Kraznys mo Nakloz", "Missandei", "Daario Naharis" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which maester at Winterfell wears several chains and helps Bran Stark learn?",
        answers = new[] { "Maester Aemon", "Maester Luwin", "Maester Pycelle", "Maester Qyburn" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which of these characters is knighted just before the Battle of Winterfell?",
        answers = new[] { "Podrick Payne", "Brienne of Tarth", "Theon Greyjoy", "Ser Davos Seaworth" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },

new QuestionData
{
    questionText = "Which Targaryen king completed the construction of the Red Keep?",
    answers = new[] { "Aegon I", "Maegor I", "Aegon III", "Aenys I" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the Dothraki city where Daenerys survives the temple fire?",
    answers = new[] { "Vaes Dothrak", "Meereen", "Lys", "Yunkai" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who poisoned Myrcella Baratheon?",
    answers = new[] { "Tyene Sand", "Ellaria Sand", "Obara Sand", "Nymeria Sand" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the Night King’s dragon after resurrection?",
    answers = new[] { "Rhaegal", "Viserion", "Drogon", "Balerion" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which house is sworn to protect the Vale?",
    answers = new[] { "House Royce", "House Hightower", "House Reed", "House Dayne" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What rare metal is mined on Dragonstone?",
    answers = new[] { "Gold", "Dragonglass", "Iron", "Copper" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who was the first Lord Commander of the Night’s Watch to be murdered by his own men?",
    answers = new[] { "Jeor Mormont", "Jon Snow", "Bowen Marsh", "Alliser Thorne" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the Stark ancestral crypt beneath Winterfell?",
    answers = new[] { "The Catacombs", "The Crypts of Winterfell", "The Cold Halls", "The Deep Tombs" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who is the last surviving male Baratheon by the end of the show?",
    answers = new[] { "Stannis", "Gendry", "Tommen", "Joffrey" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which city does Tyrion govern while Daenerys is away?",
    answers = new[] { "Qarth", "Yunkai", "Meereen", "Astapor" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What do the Faceless Men use to magically disguise themselves?",
    answers = new[] { "Blood magic", "Glamour stones", "The faces of the dead", "Illusion spells" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Lannister founded the Lannister dynasty’s wealth by discovering gold mines?",
    answers = new[] { "Lann the Clever", "Jason Lannister", "Tytos Lannister", "Garth Greenhand" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the sword used by Oberyn Martell in his duel with the Mountain?",
    answers = new[] { "Sunspear", "Viper’s Talon", "The Spear of Dorne", "It is unnamed in the show" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What undead creature kills Lord Commander Jeor Mormont?",
    answers = new[] { "A Wight", "A White Walker", "The Night King", "A resurrected giant" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which maester experimented with necromancy?",
    answers = new[] { "Pycelle", "Qyburn", "Luwin", "Aemon" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What group of elite soldiers defends the Free City of Braavos?",
    answers = new[] { "The Stormcrows", "The Second Sons", "The Faceless Men", "The Titan’s Bastards" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What massive chain is used in the Battle of Blackwater?",
    answers = new[] { "The Black Chain", "The Great Chain", "The River Chain", "The Lannister Chain" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who rules over the Stormlands after Renly’s death?",
    answers = new[] { "Stannis", "Gendry", "Brienne", "Tyrion" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the giant who fights at the Battle of the Bastards?",
    answers = new[] { "Mag the Mighty", "Wun Wun", "Dongo", "Grenn" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What castle guards the Neck and serves as the entrance to the North?",
    answers = new[] { "Winterfell", "Moat Cailin", "Riverrun", "White Harbor" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What rare Valyrian steel dagger is involved in Bran Stark’s assassination attempt?",
    answers = new[] { "Dark Sister", "Catspaw Dagger", "Blackfyre", "Heartsbane" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who kills the Night King?",
    answers = new[] { "Jon Snow", "Arya Stark", "Bran Stark", "Daenerys" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which religious group burns Shireen Baratheon alive?",
    answers = new[] { "The Drowned Men", "The Seven", "Followers of R’hllor", "The Faith Militant" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which city is known as the 'Gateway to the East'?",
    answers = new[] { "Pentos", "Volantis", "Braavos", "Qarth" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the elite Unsullied commander before Grey Worm?",
    answers = new[] { "White Rat", "Kraznys", "Missandei", "There is none named in the show" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which bloodline is considered the oldest noble house in Westeros?",
    answers = new[] { "House Durrandon", "House Stark", "House Arryn", "House Dayne" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which fortress contains a giant weirwood tree and is home to the Children of the Forest?",
    answers = new[] { "The Nightfort", "The Eyrie", "The Three-Eyed Raven’s Cave", "Casterly Rock" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What chemical does Tyrion use to burn the Lannister fleet at Blackwater?",
    answers = new[] { "Wildfire", "Dragonglass oil", "Dragonflame", "Volatile oil" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What weapon does Arya use to kill the Night King?",
    answers = new[] { "Needle", "Valyrian steel dagger", "Longclaw", "Oathkeeper" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who is the Three-Eyed Raven before Bran Stark?",
    answers = new[] { "Leaf", "Jojen Reed", "Bloodraven", "Benjen Stark" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
}

};

        var hp = new List<QuestionData>
{
    // --------------------------------------------------------
    // HARRY POTTER – EASY (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "What house is Harry Potter sorted into?",
        answers = new[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of Harry’s owl?",
        answers = new[] { "Errol", "Pigwidgeon", "Hedwig", "Crookshanks" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What position does Harry play in Quidditch?",
        answers = new[] { "Keeper", "Chaser", "Beater", "Seeker" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What platform takes students to Hogwarts?",
        answers = new[] { "Platform 8¾", "Platform 9¾", "Platform 10¼", "Platform 11¾" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the school Harry attends?",
        answers = new[] { "Durmstrang", "Beauxbatons", "Ilvermorny", "Hogwarts" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is Ron’s last name?",
        answers = new[] { "Dursley", "Diggory", "Weasley", "Malfoy" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the dark wizard Harry must defeat?",
        answers = new[] { "Gellert Grindelwald", "Lucius Malfoy", "Lord Voldemort", "Sirius Black" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What shape is Harry’s scar?",
        answers = new[] { "Star", "Moon", "Lightning bolt", "Circle" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What sport is played on broomsticks?",
        answers = new[] { "Quidditch", "Bludger Ball", "Snitch Chase", "Broom Derby" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is Harry’s first best friend at Hogwarts?",
        answers = new[] { "Draco Malfoy", "Neville Longbottom", "Ron Weasley", "Dean Thomas" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What color is the Hogwarts Express?",
        answers = new[] { "Blue", "Green", "Red", "Black" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which house does Draco Malfoy belong to?",
        answers = new[] { "Gryffindor", "Slytherin", "Hufflepuff", "Ravenclaw" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is Hagrid’s job at Hogwarts when we first meet him?",
        answers = new[] { "Gamekeeper", "Caretaker", "Potions Master", "Librarian" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which magical device helps Harry breathe underwater in the Triwizard Tournament?",
        answers = new[] { "Time-Turner", "Gillyweed", "Felix Felicis", "Polyjuice Potion" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the Weasley family home?",
        answers = new[] { "The Burrow", "Shell Cottage", "Grimmauld Place", "Hogsmeade House" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What creature is Dobby?",
        answers = new[] { "Goblin", "Hippogriff", "House-elf", "Troll" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which house is known for loyalty and hard work?",
        answers = new[] { "Ravenclaw", "Slytherin", "Gryffindor", "Hufflepuff" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the headmaster of Hogwarts for most of the series?",
        answers = new[] { "Severus Snape", "Albus Dumbledore", "Minerva McGonagall", "Dolores Umbridge" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Where do students buy their wands?",
        answers = new[] { "Madam Malkin’s", "Flourish and Blotts", "Ollivanders", "The Leaky Cauldron" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What type of pet is Crookshanks?",
        answers = new[] { "Owl", "Rat", "Toad", "Cat" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },

    new QuestionData
    {
    questionText = "What is Hermione’s last name?",
    answers = new[] { "Granger", "Potter", "Weasley", "Lovegood" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Ron Weasley’s pet rat?",
    answers = new[] { "Scabbers", "Crookshanks", "Pigwidgeon", "Fang" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the only all-wizarding village near Hogwarts?",
    answers = new[] { "Godric’s Hollow", "Hogsmeade", "Little Whinging", "Ottery St Catchpole" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the wizarding bank in Diagon Alley?",
    answers = new[] { "Gringotts", "Flourish & Blotts", "Ollivanders", "Weasleys’ Wizard Wheezes" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the main wizarding shopping street in London?",
    answers = new[] { "Knockturn Alley", "Privet Drive", "Diagon Alley", "Charing Cross Road" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "At which train station do students board the Hogwarts Express?",
    answers = new[] { "Paddington", "King’s Cross", "Waterloo", "Victoria" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Harry’s spoiled cousin?",
    answers = new[] { "Dudley Dursley", "Neville Longbottom", "Seamus Finnigan", "Dean Thomas" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Harry’s aunt who lives at Privet Drive?",
    answers = new[] { "Petunia Dursley", "Molly Weasley", "Minerva McGonagall", "Aunt Marge" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Hogwarts house is known for ambition and cunning?",
    answers = new[] { "Gryffindor", "Ravenclaw", "Hufflepuff", "Slytherin" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Hogwarts house values intelligence, wit, and learning?",
    answers = new[] { "Ravenclaw", "Hufflepuff", "Gryffindor", "Slytherin" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Hogwarts house is known for bravery and chivalry?",
    answers = new[] { "Hufflepuff", "Slytherin", "Gryffindor", "Ravenclaw" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the ghost of Gryffindor house?",
    answers = new[] { "Nearly Headless Nick", "The Bloody Baron", "The Grey Lady", "The Fat Friar" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What magical object decides which house students belong to?",
    answers = new[] { "The Elder Wand", "The Sorting Hat", "The Pensieve", "The Goblet of Fire" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the three-headed dog guarding the trapdoor in Harry’s first year?",
    answers = new[] { "Norbert", "Fang", "Fluffy", "Aragog" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What kind of creature is Buckbeak?",
    answers = new[] { "Hippogriff", "Thestral", "Acromantula", "Basilisk" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Ron Weasley’s mother?",
    answers = new[] { "Petunia", "Molly", "Lily", "Poppy" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Ron Weasley’s father?",
    answers = new[] { "Arthur", "James", "Lucius", "Vernon" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is Lord Voldemort’s real name?",
    answers = new[] { "Tom Marvolo Riddle", "Gellert Grindelwald", "Salazar Slytherin", "Severus Snape" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Hogwarts house does Cedric Diggory belong to?",
    answers = new[] { "Gryffindor", "Slytherin", "Hufflepuff", "Ravenclaw" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "In the Triwizard Tournament, how many champions are supposed to compete originally?",
    answers = new[] { "Two", "Three", "Four", "Seven" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the librarian at Hogwarts?",
    answers = new[] { "Madam Pince", "Madam Pomfrey", "Madam Rosmerta", "Madam Hooch" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who teaches Charms at Hogwarts?",
    answers = new[] { "Severus Snape", "Filius Flitwick", "Pomona Sprout", "Remus Lupin" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which Quidditch position does Ron eventually play for Gryffindor?",
    answers = new[] { "Seeker", "Beater", "Chaser", "Keeper" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which magical object makes Harry invisible?",
    answers = new[] { "The Time-Turner", "The Invisibility Cloak", "The Marauder’s Map", "The Elder Wand" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the purple triple-decker bus that helps stranded witches and wizards?",
    answers = new[] { "The Magic Coach", "The Night Bus", "The Knight Bus", "The Wizard Wagon" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What are the names of the Weasley twins?",
    answers = new[] { "Fred and George", "Bill and Charlie", "Percy and Ron", "James and Sirius" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Dobby was originally the house-elf of which family?",
    answers = new[] { "The Dursleys", "The Weasleys", "The Malfoys", "The Potters" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of Hagrid’s giant spider friend in the Forbidden Forest?",
    answers = new[] { "Fluffy", "Aragog", "Norbert", "Fang" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "In which village were Harry’s parents killed?",
    answers = new[] { "Godric’s Hollow", "Little Hangleton", "Hogsmeade", "Little Whinging" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What color light is produced by the Killing Curse, Avada Kedavra?",
    answers = new[] { "Red", "Blue", "Green", "White" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},

    // --------------------------------------------------------
    // HARRY POTTER – MEDIUM (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Who is the Half-Blood Prince?",
        answers = new[] { "Harry Potter", "Tom Riddle", "Severus Snape", "Draco Malfoy" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What magical object shows a person’s deepest desire?",
        answers = new[] { "Mirror of Erised", "Pensieve", "Time-Turner", "Foe Glass" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who was headmaster of Hogwarts before Dumbledore?",
        answers = new[] { "Armando Dippet", "Phineas Nigellus Black", "Dexter Fortescue", "Everard" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What are the three Unforgivable Curses?",
        answers = new[] {
            "Expelliarmus, Stupefy, Avada Kedavra",
            "Crucio, Imperio, Avada Kedavra",
            "Lumos, Nox, Incendio",
            "Obliviate, Confundo, Sectumsempra"
        },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is Hagrid’s giant half-brother’s name?",
        answers = new[] { "Grawp", "Karkus", "Colbert", "Ragnar" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which spell conjures a Patronus?",
        answers = new[] { "Expecto Patronum", "Expelliarmus", "Protego", "Lumos Maxima" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who teaches Potions in Harry’s sixth year?",
        answers = new[] { "Horace Slughorn", "Severus Snape", "Pomona Sprout", "Filius Flitwick" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Where is Sirius Black’s family home that becomes the Order of the Phoenix headquarters?",
        answers = new[] { "12 Grimmauld Place", "Spinner’s End", "Ottery St. Catchpole", "Little Whinging" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who kills Bellatrix Lestrange?",
        answers = new[] { "Molly Weasley", "Hermione Granger", "Nymphadora Tonks", "Ginny Weasley" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which vault at Gringotts held the Philosopher’s Stone?",
        answers = new[] { "Vault 713", "Vault 113", "Vault 619", "Vault 87" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What creature pulls the Hogwarts carriages (visible only to those who’ve seen death)?",
        answers = new[] { "Thestrals", "Hippogriffs", "Centaurs", "Manticores" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which magical plant has a cry that can kill when fully grown?",
        answers = new[] { "Mandrake", "Devil’s Snare", "Whomping Willow", "Venomous Tentacula" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who becomes the Minister for Magic after Voldemort’s defeat (as shown in the books)?",
        answers = new[] { "Rufus Scrimgeour", "Pius Thicknesse", "Kingsley Shacklebolt", "Arthur Weasley" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the prison guarded by Dementors?",
        answers = new[] { "Askaban", "Azkaban", "Nurmengard", "Grimhold" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which magical object shows memories?",
        answers = new[] { "Pensieve", "Mirror of Erised", "Deluminator", "Portkey" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What Animagus form does Minerva McGonagall take?",
        answers = new[] { "Tabby cat", "Hawk", "Fox", "Owl" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What magical device does Dumbledore leave to Ron in his will?",
        answers = new[] { "The Invisibility Cloak", "The Deluminator", "The Elder Wand", "The Pensieve" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Voldemort’s snake?",
        answers = new[] { "Nagini", "Naga", "Serpenta", "Viperella" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the codename used by Fred and George on Potterwatch?",
        answers = new[] { "Rapier and Rodent", "River and Ridge", "Rattles and Forge", "Ears and Paws" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },

    new QuestionData
{
    questionText = "Who becomes Headmaster of Hogwarts after Dumbledore’s death (during Deathly Hallows)?",
    answers = new[] { "Minerva McGonagall", "Severus Snape", "Dolores Umbridge", "Kingsley Shacklebolt" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What subject does Remus Lupin teach at Hogwarts?",
    answers = new[] { "Potions", "Transfiguration", "Defence Against the Dark Arts", "Charms" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which werewolf is responsible for biting Remus Lupin as a child?",
    answers = new[] { "Fenrir Greyback", "Sirius Black", "Remus Lupin himself", "Rufus Scrimgeour" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Argus Filch’s cat?",
    answers = new[] { "Mrs Norris", "Crookshanks", "Mrs Pince", "Miss Malkin" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "In which Ministry office does Arthur Weasley first work?",
    answers = new[] { "Auror Office", "Misuse of Muggle Artefacts Office", "Department of Mysteries", "International Magical Cooperation" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the famous Bulgarian Seeker at the Quidditch World Cup in Goblet of Fire?",
    answers = new[] { "Oliver Wood", "Viktor Krum", "Marcus Flint", "Roger Davies" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which spell is commonly used as the Disarming Charm?",
    answers = new[] { "Stupefy", "Expelliarmus", "Rictusempra", "Obliviate" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Fawkes, Dumbledore’s pet, is what magical creature?",
    answers = new[] { "Hippogriff", "Phoenix", "Thestral", "House-elf" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What phrase must be spoken to activate the Marauder’s Map?",
    answers = new[] { "Mischief managed", "I solemnly swear that I am up to no good", "Open at the close", "Nothing to see here" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What phrase must be spoken to close and conceal the Marauder’s Map?",
    answers = new[] { "Finite incantatem", "Mischief managed", "Obliviate", "Close and be still" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who does Harry take to the Yule Ball?",
    answers = new[] { "Hermione Granger", "Cho Chang", "Parvati Patil", "Ginny Weasley" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who does Hermione attend the Yule Ball with?",
    answers = new[] { "Viktor Krum", "Cedric Diggory", "Ron Weasley", "Harry Potter" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the ghost of Slytherin house?",
    answers = new[] { "Nearly Headless Nick", "The Fat Friar", "The Bloody Baron", "The Grey Lady" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the ghost of Ravenclaw house, also known as the Grey Lady?",
    answers = new[] { "Moaning Myrtle", "Helena Ravenclaw", "Arabella Figg", "Charity Burbage" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who casts the Killing Curse that causes Dumbledore’s death?",
    answers = new[] { "Draco Malfoy", "Severus Snape", "Bellatrix Lestrange", "Fenrir Greyback" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which spell is used to unlock doors?",
    answers = new[] { "Alohomora", "Accio", "Reducto", "Wingardium Leviosa" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What magical object does Hermione use to attend multiple classes at once in her third year?",
    answers = new[] { "Time-Turner", "Portkey", "Deluminator", "Pensieve" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the Defence Against the Dark Arts teacher in Harry’s second year?",
    answers = new[] { "Remus Lupin", "Gilderoy Lockhart", "Mad-Eye Moody", "Quirinus Quirrell" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the Defence Against the Dark Arts teacher in Harry’s third year?",
    answers = new[] { "Remus Lupin", "Gilderoy Lockhart", "Dolores Umbridge", "Severus Snape" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What does the organization S.P.E.W., founded by Hermione, stand for?",
    answers = new[] { "Society for the Protection of Elven Workers", "Society for the Promotion of Elfish Welfare", "Society for Protecting Elf Wands", "Society for the Preservation of Elder Wand" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the half-giant headmistress of Beauxbatons Academy of Magic?",
    answers = new[] { "Minerva McGonagall", "Olympe Maxime", "Madam Hooch", "Bathilda Bagshot" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is the headmaster of Durmstrang Institute during the Triwizard Tournament?",
    answers = new[] { "Igor Karkaroff", "Viktor Krum", "Madame Maxime", "Antonin Dolohov" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Draco Malfoy’s mother?",
    answers = new[] { "Bellatrix Lestrange", "Narcissa Malfoy", "Andromeda Tonks", "Merope Gaunt" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What first name does Nymphadora Tonks prefer people use?",
    answers = new[] { "Nymphadora", "Dora", "Tonks", "Nyma" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Remus Lupin and Nymphadora Tonks’s son?",
    answers = new[] { "James Sirius Potter", "Teddy Lupin", "Albus Severus Potter", "Colin Creevey" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "From which school does Fleur Delacour come to participate in the Triwizard Tournament?",
    answers = new[] { "Hogwarts", "Durmstrang", "Beauxbatons", "Ilvermorny" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Where does Bill Weasley work after Hogwarts?",
    answers = new[] { "Ollivanders", "Flourish and Blotts", "Gringotts Wizarding Bank", "The Leaky Cauldron" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What career does Percy Weasley pursue after leaving Hogwarts?",
    answers = new[] { "Dragon keeper", "Auror", "Ministry of Magic official", "Quidditch player" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who works as the conductor on the Knight Bus when Harry first boards it?",
    answers = new[] { "Ernie Prang", "Stan Shunpike", "Rubeus Hagrid", "Cornelius Fudge" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},

    // --------------------------------------------------------
    // HARRY POTTER – HARD (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Who was the original owner of the Elder Wand, according to the tale?",
        answers = new[] { "Antioch Peverell", "Cadmus Peverell", "Ignotus Peverell", "Gellert Grindelwald" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is Dumbledore’s full name?",
        answers = new[]
        {
            "Albus Percival Wulfric Brian Dumbledore",
            "Albus Marcus Belgrave Dumbledore",
            "Albus Silvanus Brian Dumbledore",
            "Albus Percival Aurelius Dumbledore"
        },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is Hermione Granger’s Patronus form?",
        answers = new[] { "Otter", "Cat", "Hare", "Horse" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which plant is used to revive those who have been Petrified?",
        answers = new[] { "Mandrake", "Mimbulus mimbletonia", "Devil’s Snare", "Fluxweed" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which goblin helps Harry break into Gringotts?",
        answers = new[] { "Griphook", "Ragnuk", "Bogrod", "Silvernaut" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "How many Horcruxes did Voldemort intentionally create?",
        answers = new[] { "6", "5", "7", "8" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which charm hides the location of the Order of the Phoenix headquarters?",
        answers = new[] { "Fidelius Charm", "Protean Charm", "Disillusionment Charm", "Confundus Charm" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of Hagrid’s mother?",
        answers = new[] { "Fridwulfa", "Morana", "Selwynna", "Myrtle" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who gifts Harry the Firebolt in his third year (initially anonymously)?",
        answers = new[] { "Sirius Black", "Remus Lupin", "Minerva McGonagall", "Albus Dumbledore" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is Voldemort’s mother’s name?",
        answers = new[] { "Merope Gaunt", "Eileen Prince", "Walburga Black", "Morfin Gaunt" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which vault at Gringotts holds a Horcrux belonging to Bellatrix, actually Voldemort’s?",
        answers = new[] { "Vault 713", "Vault 687", "Vault 711", "Vault 711B" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What form does Ron Weasley’s Patronus take?",
        answers = new[] { "Jack Russell terrier", "Stag", "Goat", "Weasel" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which magical law enforcement group does Kingsley Shacklebolt belong to before becoming Minister?",
        answers = new[] { "Auror Office", "Improper Use of Magic Office", "Hit Wizards", "Muggle-Worthy Excuse Committee" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the book that teaches Harry Sectumsempra?",
        answers = new[] { "The Standard Book of Spells", "Advanced Potion-Making", "Moste Potente Potions", "Dark Arts Unleashed" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which magical creature’s tail hair is in Harry’s wand core?",
        answers = new[] { "Phoenix", "Unicorn", "Dragon", "Thestral" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the authors of 'The Tales of Beedle the Bard'?",
        answers = new[] { "Beedle the Bard", "Bathilda Bagshot", "Phyllida Spore", "Newt Scamander" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which potion is also known as 'liquid luck'?",
        answers = new[] { "Polyjuice Potion", "Felix Felicis", "Amortentia", "Veritaserum" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What object does Dumbledore use to store and review memories?",
        answers = new[] { "Pensieve", "Time-Turner", "Deluminator", "Foe Glass" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the curse placed on the Defence Against the Dark Arts position?",
        answers = new[] { "It was jinxed by Voldemort", "It was cursed by Grindelwald", "It was cursed by Salazar Slytherin", "There is no curse" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },

    new QuestionData
{
    questionText = "Who is the famous alchemist that created the Philosopher’s Stone?",
    answers = new[] { "Nicolas Flamel", "Gellert Grindelwald", "Bathilda Bagshot", "Newt Scamander" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of Rowena Ravenclaw’s daughter, later known as the Grey Lady?",
    answers = new[] { "Helena Ravenclaw", "Ariana Dumbledore", "Merope Gaunt", "Andromeda Black" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who are the four founders of Hogwarts?",
    answers = new[] { "Godric Gryffindor, Salazar Slytherin, Rowena Ravenclaw, Helga Hufflepuff", "Dumbledore, McGonagall, Snape, Hagrid", "Nicolas Flamel, Merlin, Morgana, Ignotus", "Grindelwald, Krum, Fleur, Hagrid" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "In which village is the Burrow, the Weasley family home, located?",
    answers = new[] { "Godric’s Hollow", "Little Hangleton", "Ottery St Catchpole", "Little Whinging" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What was Lily Potter’s maiden name?",
    answers = new[] { "Evans", "Prince", "Black", "Gaunt" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What form does James Potter’s Animagus take?",
    answers = new[] { "Stag", "Dog", "Rat", "Wolf" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What form does Sirius Black’s Animagus take?",
    answers = new[] { "Wolf", "Rat", "Large black dog", "Stag" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What form does Peter Pettigrew’s Animagus take?",
    answers = new[] { "Cat", "Rat", "Dog", "Stag" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Marauder is known by the nickname 'Moony'?",
    answers = new[] { "James Potter", "Sirius Black", "Peter Pettigrew", "Remus Lupin" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Marauder is known by the nickname 'Padfoot'?",
    answers = new[] { "James Potter", "Sirius Black", "Peter Pettigrew", "Remus Lupin" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Marauder is known by the nickname 'Wormtail'?",
    answers = new[] { "James Potter", "Sirius Black", "Peter Pettigrew", "Remus Lupin" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Marauder is known by the nickname 'Prongs'?",
    answers = new[] { "James Potter", "Sirius Black", "Peter Pettigrew", "Remus Lupin" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who kills Nagini, Voldemort’s snake, during the Battle of Hogwarts?",
    answers = new[] { "Harry Potter", "Neville Longbottom", "Hermione Granger", "Ron Weasley" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of Albus Dumbledore’s brother?",
    answers = new[] { "Aberforth", "Percival", "Regulus", "Gellert" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the pub in Hogsmeade run by Aberforth Dumbledore?",
    answers = new[] { "The Leaky Cauldron", "The Hog’s Head", "The Three Broomsticks", "The Hanged Man" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "At what numbered house on Privet Drive do the Dursleys live?",
    answers = new[] { "Number 2", "Number 4", "Number 6", "Number 12" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "In which town is Privet Drive located?",
    answers = new[] { "Godric’s Hollow", "Little Whinging", "Ottery St Catchpole", "Hogsmeade" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What number must be dialed on the old red telephone box to enter the Ministry of Magic via visitor’s entrance?",
    answers = new[] { "62442", "73642", "63999", "77777" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of Voldemort’s Muggle father?",
    answers = new[] { "Morfin Gaunt", "Tom Riddle Sr.", "James Potter", "Marvolo Riddle" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the full name of Harry’s Aunt Marge?",
    answers = new[] { "Margaret Dursley", "Marjorie Dursley", "Mary Dursley", "Mildred Dursley" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of Fleur Delacour’s younger sister?",
    answers = new[] { "Gabrielle", "Apolline", "Victoire", "Dominique" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the magical quill used by Rita Skeeter to write sensational articles?",
    answers = new[] { "Self-Inking Quill", "Smart-Quotes Quill", "Quick-Quotes Quill", "Truth-Telling Quill" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Into what creature can Rita Skeeter secretly transform as an unregistered Animagus?",
    answers = new[] { "Cat", "Beetle", "Owl", "Rat" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of Albus Dumbledore’s mother?",
    answers = new[] { "Kendra", "Ariana", "Merope", "Eileen" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of Dumbledore’s younger sister?",
    answers = new[] { "Helena", "Ariana", "Andromeda", "Lily" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the full name of Sirius Black’s younger brother?",
    answers = new[] { "Regulus Arcturus Black", "Orion Sirius Black", "Phineas Nigellus Black", "Pollux Black" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which artifact of Salazar Slytherin is turned into a Horcrux?",
    answers = new[] { "A ring", "A cup", "A locket", "A diadem" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which artifact of Helga Hufflepuff becomes one of Voldemort’s Horcruxes?",
    answers = new[] { "A sword", "A cup", "A locket", "A ring" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which lost artifact of Rowena Ravenclaw becomes a Horcrux hidden in the Room of Requirement?",
    answers = new[] { "Her wand", "Her necklace", "Her diadem", "Her goblet" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
}
};

        var starWars = new List<QuestionData>
{
    // --------------------------------------------------------
    // STAR WARS – EASY (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "What is Luke's last name?",
        answers = new[] { "Skywalker", "Kenobi", "Solo", "Organa" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What weapon is commonly used by Jedi Knights?",
        answers = new[] { "Blaster", "Lightsaber", "Bowcaster", "Thermal detonator" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "On which desert planet does Luke Skywalker grow up?",
        answers = new[] { "Tatooine", "Jakku", "Geonosis", "Mustafar" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is Luke's sister?",
        answers = new[] { "Rey", "Padmé", "Leia Organa", "Ahsoka Tano" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which small green Jedi Master trains Luke on Dagobah?",
        answers = new[] { "Yoda", "Mace Windu", "Ki-Adi-Mundi", "Plo Koon" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which smuggler owns the Millennium Falcon?",
        answers = new[] { "Lando Calrissian", "Han Solo", "Poe Dameron", "Cassian Andor" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of Han Solo's Wookiee co-pilot?",
        answers = new[] { "Chewbacca", "Tarfful", "Zeb", "Wicket" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which droid carries the Death Star plans in 'A New Hope'?",
        answers = new[] { "BB-8", "C-3PO", "R2-D2", "K-2SO" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who built the protocol droid C-3PO?",
        answers = new[] { "Obi-Wan Kenobi", "Luke Skywalker", "Anakin Skywalker", "Watto" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the Empire’s planet-destroying space station?",
        answers = new[] { "Starkiller Base", "Death Star", "Star Forge", "Dreadnought" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which character famously reveals 'I am your father' to Luke?",
        answers = new[] { "Emperor Palpatine", "Obi-Wan Kenobi", "Darth Vader", "Mace Windu" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the order that commands the clones to kill the Jedi?",
        answers = new[] { "Order 13", "Order 66", "Order 99", "Order 7" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which group fights against the Galactic Empire?",
        answers = new[] { "Trade Federation", "First Order", "Rebel Alliance", "Jedi Council" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the furry species living on Endor?",
        answers = new[] { "Jawas", "Ewoks", "Tusken Raiders", "Wookiees" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which bounty hunter first captures Han Solo in 'The Empire Strikes Back'?",
        answers = new[] { "Greedo", "Boba Fett", "Jango Fett", "Cad Bane" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What material is Han Solo frozen in?",
        answers = new[] { "Durasteel", "Carbonite", "Beskar", "Plasteel" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
new QuestionData
{
    questionText = "What color is Luke Skywalker's lightsaber in 'Return of the Jedi'?",
    answers = new[] { "Blue", "Green", "Red", "Purple" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},

    new QuestionData
    {
        questionText = "What is the name of the sinister organization that replaces the Empire in the sequel trilogy?",
        answers = new[] { "Trade Federation", "Confederacy of Independent Systems", "First Order", "Hutt Cartel" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the Supreme Leader of the First Order in 'The Force Awakens'?",
        answers = new[] { "General Hux", "Supreme Leader Snoke", "Darth Maul", "Count Dooku" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which droid is fluent in over six million forms of communication?",
        answers = new[] { "R2-D2", "BB-8", "C-3PO", "IG-88" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },

    new QuestionData
    {
        questionText = "What is the mystical energy field used by Jedi and Sith called?",
        answers = new[] { "The Source", "The Force", "The Flow", "The Current" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is Darth Vader’s real name?",
        answers = new[] { "Darth Maul", "Ben Kenobi", "Anakin Skywalker", "Mace Windu" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which princess is a leader of the Rebel Alliance and sister to Luke?",
        answers = new[] { "Padmé Amidala", "Leia Organa", "Ahsoka Tano", "Bo-Katan Kryze" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which icy planet is the location of the Rebel base in 'The Empire Strikes Back'?",
        answers = new[] { "Hoth", "Bespin", "Endor", "Naboo" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which planet is destroyed by the Death Star in 'A New Hope'?",
        answers = new[] { "Naboo", "Alderaan", "Geonosis", "Tatooine" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the Jedi Master that first trains Anakin Skywalker?",
        answers = new[] { "Mace Windu", "Qui-Gon Jinn", "Yoda", "Plo Koon" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which smuggler becomes a general in the Rebel Alliance and marries Leia?",
        answers = new[] { "Lando Calrissian", "Han Solo", "Cassian Andor", "Wedge Antilles" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What color is Darth Vader’s lightsaber?",
        answers = new[] { "Blue", "Green", "Purple", "Red" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which bounty hunter confronts Han Solo in the Mos Eisley Cantina?",
        answers = new[] { "Bossk", "Cad Bane", "Greedo", "Boba Fett" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the Hutt crime lord on Tatooine?",
        answers = new[] { "Jabba", "Ziro", "Gardulla", "Rotta" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What species is Chewbacca?",
        answers = new[] { "Rodian", "Wookiee", "Twi'lek", "Zabrak" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the clone trooper commander who serves directly under Anakin Skywalker in 'The Clone Wars'?",
        answers = new[] { "Commander Cody", "Captain Rex", "Commander Gree", "Commander Wolffe" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of Anakin Skywalker’s Padawan learner in 'The Clone Wars'?",
        answers = new[] { "Ahsoka Tano", "Barriss Offee", "Shaak Ti", "Asajj Ventress" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which Mandalorian bounty hunter wears distinctive green armor and a T-shaped visor in the original trilogy?",
        answers = new[] { "Din Djarin", "Pre Vizsla", "Boba Fett", "Jango Fett" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who says the line 'Help me, Obi-Wan Kenobi. You’re my only hope.'?",
        answers = new[] { "Padmé Amidala", "Leia Organa", "Ahsoka Tano", "Mon Mothma" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which planet is the homeworld of Jar Jar Binks?",
        answers = new[] { "Coruscant", "Naboo", "Geonosis", "Kashyyyk" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the clone wars-era general who leads the Separatist droid armies with four lightsabers?",
        answers = new[] { "Count Dooku", "General Grievous", "Asajj Ventress", "Admiral Trench" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which Jedi Master is known for his purple lightsaber?",
        answers = new[] { "Kit Fisto", "Plo Koon", "Mace Windu", "Saesee Tiin" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which planet is the homeworld of the Wookiees?",
        answers = new[] { "Kashyyyk", "Endor", "Ryloth", "Tatooine" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the ship flown by the Mandalorian Din Djarin in Season 1 of 'The Mandalorian'?",
        answers = new[] { "Razor Crest", "Ghost", "Slave I", "Outrider" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What nickname is given to the small green child traveling with Din Djarin?",
        answers = new[] { "The Kid", "The Child / Grogu", "Little Yoda", "Tiny One" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which former Jedi Knight appears in 'Star Wars Rebels' as the mentor to Ezra Bridger?",
        answers = new[] { "Kanan Jarrus", "Ahsoka Tano", "Luke Skywalker", "Cal Kestis" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "In 'Star Wars Rebels', what is the name of the main ship used by the crew?",
        answers = new[] { "Razor Crest", "Ghost", "Tantive IV", "Home One" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which Clone Wars-era planet is made mostly of oceans and used for clone production?",
        answers = new[] { "Kamino", "Mustafar", "Felucia", "Saleucami" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the main Sith Lord that Anakin Skywalker serves as Darth Vader?",
        answers = new[] { "Darth Maul", "Darth Tyranus", "Darth Sidious", "Darth Bane" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What sandy planet is also the home of Anakin Skywalker as a boy?",
        answers = new[] { "Tatooine", "Jakku", "Jedha", "Dantooine" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which animal-like mounts do Tusken Raiders ride on Tatooine?",
        answers = new[] { "Tauntauns", "Banthas", "Dewbacks", "Nexu" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the main character of the 'Obi-Wan Kenobi' series?",
        answers = new[] { "Anakin Skywalker", "Obi-Wan Kenobi", "Mace Windu", "Yoda" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "In 'Attack of the Clones', what kind of arena beasts attack Anakin, Padmé, and Obi-Wan on Geonosis?",
        answers = new[] { "Acklay, Nexu, Reek", "Rancor, Wampa, Sarlacc", "Dewback, Bantha, Tauntaun", "Varactyl, Loth-cat, Blurrg" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the title given to the guardians of peace and justice in the galaxy who use the light side of the Force?",
        answers = new[] { "The Sith", "The Mandalorians", "The Jedi", "The Inquisitors" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },

    

    // --------------------------------------------------------
    // STAR WARS – MEDIUM (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "On which planet does Obi-Wan Kenobi fight Anakin Skywalker in 'Revenge of the Sith'?",
        answers = new[] { "Mustafar", "Naboo", "Kashyyyk", "Geonosis" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which bounty hunter is the genetic template for the clone army?",
        answers = new[] { "Boba Fett", "Cad Bane", "Jango Fett", "Bossk" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "On which planet do the Clone Wars officially begin with a massive arena battle?",
        answers = new[] { "Kamino", "Geonosis", "Utapau", "Felucia" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the desert scavenger Rey's home world in 'The Force Awakens'?",
        answers = new[] { "Tatooine", "Jakku", "Jedha", "Lothal" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
    questionText = "In 'The Phantom Menace', what species is Jar Jar Binks?",
    answers = new[] { "Gungan", "Twi'lek", "Rodian", "Wookiee" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
    },

    new QuestionData
    {
        questionText = "Which clone order enforces that there are only ever two Sith at a time?",
        answers = new[] { "The New Order", "The Binary Code", "The Rule of Two", "The Final Directive" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "On which planet is the Jedi Temple seen in the prequel trilogy located?",
        answers = new[] { "Coruscant", "Alderaan", "Yavin 4", "Corellia" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is Padmé Amidala’s home planet?",
        answers = new[] { "Coruscant", "Naboo", "Alderaan", "Cato Neimoidia" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who kills Count Dooku in 'Revenge of the Sith'?",
        answers = new[] { "Obi-Wan Kenobi", "Yoda", "Anakin Skywalker", "Mace Windu" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Admiral famously says 'It's a trap!' in 'Return of the Jedi'?",
        answers = new[] { "Admiral Piett", "Admiral Ackbar", "Admiral Holdo", "Admiral Thrawn" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Cloud City is located on which gas giant?",
        answers = new[] { "Bespin", "Dantooine", "Endor", "Dagobah" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who commands the first Death Star in 'A New Hope'?",
        answers = new[] { "Admiral Piett", "Grand Moff Tarkin", "General Veers", "Count Dooku" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What alien species is Admiral Ackbar?",
        answers = new[] { "Rodian", "Twi'lek", "Mon Calamari", "Devaronian" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who was Obi-Wan Kenobi's Jedi Master?",
        answers = new[] { "Yoda", "Mace Windu", "Qui-Gon Jinn", "Plo Koon" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "On which swampy planet does Yoda live in exile?",
        answers = new[] { "Dagobah", "Kamino", "Hoth", "Endor" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
    questionText = "What is the name of General Grievous's flagship in 'Revenge of the Sith'?",
    answers = new[] { "Invisible Hand", "Malevolence", "Executor", "Devastator" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
    },

    new QuestionData
    {
    questionText = "In 'Return of the Jedi', what is the name of the small creature that cackles beside Jabba the Hutt?",
    answers = new[] { "Wicket", "Salacious B. Crumb", "Nien Nunb", "Bib Fortuna" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
    },

    new QuestionData
    {
        questionText = "Which planet hosts the shield generator for the second Death Star?",
        answers = new[] { "Hoth", "Endor", "Yavin 4", "Mustafar" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Where is the Rebel base located at the end of 'Rogue One: A Star Wars Story'?",
        answers = new[] { "Scarif", "Jedha", "Takodana", "Crait" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What organization uses B1 battle droids and droidekas during the Clone Wars?",
        answers = new[] { "Galactic Empire", "Trade Federation / Separatists", "First Order", "Jedi Order" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },

    new QuestionData
    {
        questionText = "In 'The Phantom Menace', on which planet do Qui-Gon, Obi-Wan, and Padmé first meet Anakin Skywalker?",
        answers = new[] { "Tatooine", "Naboo", "Coruscant", "Mustafar" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the Gungan leader on Naboo?",
        answers = new[] { "Boss Nass", "General Tarpals", "Captain Panaka", "Watto" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Jedi Master sits on the Jedi Council and has a long neck and tall, thin head?",
        answers = new[] { "Ki-Adi-Mundi", "Saesee Tiin", "Oppo Rancisis", "Yarael Poof" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the order of Force-sensitive warriors who follow the dark side and oppose the Jedi?",
        answers = new[] { "The Mandalorians", "The Sith", "The Chiss", "The Nightsisters" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Separatist leader is also known as Darth Tyranus?",
        answers = new[] { "Count Dooku", "General Grievous", "Asajj Ventress", "Nute Gunray" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'Revenge of the Sith', on which sinkhole world does Obi-Wan confront General Grievous?",
        answers = new[] { "Utapau", "Felucia", "Mygeeto", "Mustafar" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Jedi Master leads the clone forces on Kashyyyk during 'Revenge of the Sith'?",
        answers = new[] { "Mace Windu", "Aayla Secura", "Ki-Adi-Mundi", "Yoda" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'The Clone Wars', what is the name of the clone trooper who goes by CT-5555?",
        answers = new[] { "Echo", "Fives", "Rex", "Cody" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "On which planet are the Nightsisters of Dathomir located?",
        answers = new[] { "Mandalore", "Dathomir", "Ryloth", "Onderon" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'The Mandalorian', what is the real name of 'The Child'?",
        answers = new[] { "Yaddle", "Grogu", "Goru", "Yodu" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the real name of the Mandalorian bounty hunter in 'The Mandalorian' series?",
        answers = new[] { "Boba Fett", "Jango Fett", "Din Djarin", "Pre Vizsla" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which former Jedi appears in 'The Mandalorian' Season 2 and helps guide Din Djarin and Grogu?",
        answers = new[] { "Luke Skywalker", "Ahsoka Tano", "Ezra Bridger", "Kanan Jarrus" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'Star Wars Rebels', which young Force-sensitive boy becomes Kanan Jarrus’s apprentice?",
        answers = new[] { "Ezra Bridger", "Caleb Dume", "Jacen Syndulla", "Galen Marek" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Imperial officer becomes famous in 'Star Wars Rebels' for his strategic genius and blue-skinned appearance?",
        answers = new[] { "Grand Moff Tarkin", "Admiral Piett", "Grand Admiral Thrawn", "Director Krennic" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "On which desert moon do Obi-Wan and Darth Vader have a rematch in the 'Obi-Wan Kenobi' series?",
        answers = new[] { "Jedha", "Polis Massa", "Jabiim", "A remote unnamed rocky moon (often referred to as a barren moon)" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Jabba the Hutt’s sail barge destroyed over the Great Pit of Carkoon?",
        answers = new[] { "Betrayal", "Khetanna", "Slave II", "Krayt" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "On which planet do the events of 'Rogue One' reach their climax with a massive battle and data transmission?",
        answers = new[] { "Scarif", "Jedha", "Eadu", "Yavin 4" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'Attack of the Clones', who tries to have Padmé assassinated before the Jedi uncover the plot?",
        answers = new[] { "Aurra Sing", "Zam Wesell", "Asajj Ventress", "Cad Bane" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What type of fighter does Luke Skywalker pilot in the assault on the first Death Star?",
        answers = new[] { "A-wing", "X-wing", "Y-wing", "TIE Fighter" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'Rebels', which Lasat warrior wields a bo-rifle and serves aboard the Ghost?",
        answers = new[] { "Zeb Orrelios", "Hondo Ohnaka", "Garazeb Syndulla", "Cham Syndulla" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which clone commander serves under Obi-Wan Kenobi during the Clone Wars?",
        answers = new[] { "Captain Rex", "Commander Cody", "Commander Gree", "Commander Bly" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Jedi Master fights Emperor Palpatine alongside Mace Windu before being quickly defeated?",
        answers = new[] { "Kit Fisto, Agen Kolar, Saesee Tiin", "Ki-Adi-Mundi, Plo Koon, Aayla Secura", "Yoda, Shaak Ti, Luminara Unduli", "Obi-Wan, Anakin, Ahsoka" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'The Clone Wars', which crime lord rules Mandalore as the head of the Shadow Collective for a time?",
        answers = new[] { "Jabba the Hutt", "Darth Maul", "Black Sun Vigo", "Cad Bane" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the city on Bespin where Lando Calrissian is administrator?",
        answers = new[] { "Cloud City", "Skyport Nine", "Bespin Prime", "Nimbus Station" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'Revenge of the Sith', which Jedi confronts Darth Sidious in the Senate chamber after Mace Windu's death?",
        answers = new[] { "Yoda", "Obi-Wan Kenobi", "Shaak Ti", "Kit Fisto" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which droid is Anakin Skywalker’s astromech during much of the Clone Wars?",
        answers = new[] { "R2-D2", "R4-P17", "Chopper (C1-10P)", "BB-8" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'Rebels', which former Clone Wars leader of Mandalore allies with the Ghost crew and wields the Darksaber?",
        answers = new[] { "Pre Vizsla", "Bo-Katan Kryze", "Satine Kryze", "Sabine Wren" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which planet serves as the capital of the Galactic Republic before becoming the Imperial center?",
        answers = new[] { "Coruscant", "Alderaan", "Corellia", "Cato Neimoidia" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In 'The Mandalorian', what rare metal is prized for Mandalorian armor?",
        answers = new[] { "Durasteel", "Beskar", "Carbonite", "Rhodium" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which Jedi survives Order 66 and later appears as an older hermit on Tatooine watching over Luke?",
        answers = new[] { "Yoda", "Obi-Wan Kenobi", "Mace Windu", "Plo Koon" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },

    // --------------------------------------------------------
    // STAR WARS – HARD (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "What is Emperor Palpatine's Sith name?",
        answers = new[] { "Darth Plagueis", "Darth Sidious", "Darth Tyranus", "Darth Maul" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the small Rebel corvette captured in the opening of 'A New Hope'?",
        answers = new[] { "Ghost", "Profundity", "Tantive IV", "Home One" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which gas is mined in Cloud City on Bespin?",
        answers = new[] { "Tibanna gas", "Coaxium", "Rhydonium", "Bacta vapors" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "According to the Kaminoans, which Jedi originally commissioned the clone army?",
        answers = new[] { "Mace Windu", "Sifo-Dyas", "Dooku", "Yoda" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the podrace that Anakin wins in 'The Phantom Menace'?",
        answers = new[] { "Boonta Eve Classic", "Mos Espa Rally", "Tatooine Grand Prix", "Outer Rim Dash" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the cantina in Mos Eisley where Han Solo is first seen?",
        answers = new[] { "Chalmun’s Cantina", "Dex's Diner", "Outlander Club", "Toshii Station" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Wookiee homeworld?",
        answers = new[] { "Kashyyyk", "Endor", "Dathomir", "Ryloth" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of Darth Vader's massive Super Star Destroyer?",
        answers = new[] { "Devastator", "Executor", "Ravager", "Eclipse" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Mandalorian who first forged the Darksaber?",
        answers = new[] { "Pre Vizsla", "Tarre Vizsla", "Bo-Katan Kryze", "Din Djarin" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What creature lives in the pit beneath Jabba the Hutt’s palace?",
        answers = new[] { "Sarlacc", "Rancor", "Wampa", "Exogorth" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What species is Darth Maul?",
        answers = new[] { "Zabrak", "Twi'lek", "Devaronian", "Mirialan" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "On which fiery world is Anakin Skywalker severely injured and left for dead?",
        answers = new[] { "Mustafar", "Kessel", "Mandalore", "Jedha" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who kills Jango Fett in the Battle of Geonosis?",
        answers = new[] { "Obi-Wan Kenobi", "Mace Windu", "Anakin Skywalker", "Ki-Adi-Mundi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Ewok who first befriends Princess Leia?",
        answers = new[] { "Paploo", "Teebo", "Wicket", "Chief Chirpa" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
    questionText = "In 'The Phantom Menace', which podracer is Anakin Skywalker's main rival in the Boonta Eve Classic?",
    answers = new[] { "Sebulba", "Gasgano", "Teemto Pagalies", "Ben Quadinaros" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
    },

    new QuestionData
    {
        questionText = "Which planet is Han Solo originally from?",
        answers = new[] { "Corellia", "Coruscant", "Nar Shaddaa", "Ord Mantell" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What does AT-AT stand for?",
        answers = new[] { "All Terrain Armored Transport", "Armored Tactical Assault Tank", "All Terrain Attack Transport", "Advanced Troop Assault Transport" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What are the microscopic organisms said to allow beings to connect to the Force?",
        answers = new[] { "Nanites", "Midi-chlorians", "Force cells", "Bio-cores" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the criminal syndicate that Qi'ra works for in 'Solo: A Star Wars Story'?",
        answers = new[] { "Crimson Dawn", "Black Sun", "Pike Syndicate", "Hutt Cartel" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },

    new QuestionData
    {
        questionText = "What is Count Dooku's homeworld?",
        answers = new[] { "Serenno", "Alderaan", "Kuat", "Corellia" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is Count Dooku's Sith name?",
        answers = new[] { "Darth Tyranus", "Darth Plagueis", "Darth Bane", "Darth Malgus" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Clone Wars', what is the name of the clone trooper who discovers the inhibitor chip conspiracy and is then killed?",
        answers = new[] { "Rex", "Fives", "Echo", "Jesse" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which ancient world is said to be the homeworld of the Sith species in legends and some canon material?",
        answers = new[] { "Korriban / Moraband", "Malachor", "Mustafar", "Dxun" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the designation of the clone legion led by Anakin Skywalker and Captain Rex?",
        answers = new[] { "212th Attack Battalion", "327th Star Corps", "501st Legion", "21st Nova Corps" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'Rebels', on which world do Ahsoka Tano and Darth Vader confront each other in a Sith temple?",
        answers = new[] { "Lothal", "Malachor", "Korriban", "Mustafar" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Inquisitor is known simply as 'The Grand Inquisitor' in 'Star Wars Rebels'?",
        answers = new[] { "A Pau'an former Jedi Temple Guard", "A Zabrak Sith Assassin", "A Chiss dark sider", "A Mirialan knight" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Mandalorian', which former Imperial officer wields the Darksaber?",
        answers = new[] { "Moff Jerjerrod", "Moff Gideon", "Grand Moff Tarkin", "Admiral Ozzel" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What species is Grand Admiral Thrawn?",
        answers = new[] { "Human", "Chiss", "Pantoran", "Zeltron" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'Attack of the Clones', what is the name of the tall, white alien species that runs the cloning facilities on Kamino?",
        answers = new[] { "Kaminoans", "Geonosians", "Neimoidians", "Quarren" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Jedi Master is known for the line 'It's a trap!' in a parody but actually said by a Mon Calamari admiral?",
        answers = new[] { "No Jedi said it; Admiral Ackbar did", "Yoda", "Obi-Wan Kenobi", "Plo Koon" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Clone Wars', which Nightsister becomes Count Dooku’s apprentice before being betrayed?",
        answers = new[] { "Mother Talzin", "Asajj Ventress", "Barriss Offee", "Shaak Ti" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Twi'lek Jedi Master who is killed on Felucia during Order 66?",
        answers = new[] { "Aayla Secura", "Luminara Unduli", "Shaak Ti", "Depa Billaba" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which clone commander turns his troops on Jedi Master Ki-Adi-Mundi on Mygeeto during Order 66?",
        answers = new[] { "Commander Cody", "Commander Gree", "Commander Bly", "Commander Bacara" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'Revenge of the Sith', what is the name of the Wookiee chieftain who fights alongside Yoda?",
        answers = new[] { "Tarfful", "Chewbacca", "Gungi", "Dryden" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Mandalorian', which Mandalorian leader seeks the Darksaber to reclaim Mandalore?",
        answers = new[] { "Sabine Wren", "Bo-Katan Kryze", "Pre Vizsla", "Fenn Rau" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which planet is known as the birthplace of the Mandalorian people?",
        answers = new[] { "Mandalore", "Concord Dawn", "Navarro", "Lothal" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'Star Wars Rebels', what is the name of the mystical realm accessed via portals that connect different points in time and space?",
        answers = new[] { "The Netherworld of the Force", "World Between Worlds", "The Beyond", "The Force Veil" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Clone Wars', on which planet does Ahsoka Tano leave the Jedi Order?",
        answers = new[] { "Coruscant", "Mandalore", "Onderon", "Lothal" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the order of dark side hunters tasked with tracking down surviving Jedi after Order 66?",
        answers = new[] { "The Inquisitorius", "The Shadow Collective", "The Crimson Dawn", "The Black Sun" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In the 'Obi-Wan Kenobi' series, which Inquisitor is also known as the Third Sister?",
        answers = new[] { "Reva Sevander", "Trilla Suduri", "Barriss Offee", "Morgan Elsbeth" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Jedi Master in 'The Clone Wars' has a unique head with tentacles and is known as a Nautolan?",
        answers = new[] { "Kit Fisto", "Plo Koon", "Saesee Tiin", "Even Piell" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the real name of Kanan Jarrus before he changed his identity after Order 66?",
        answers = new[] { "Caleb Dume", "Jorus C'baoth", "Rahm Kota", "Biran Ska" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'Solo: A Star Wars Story', which substance is the volatile hyperfuel being transported and refined?",
        answers = new[] { "Rhydonium", "Coaxium", "Tibanna", "Spice" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which bounty hunter from 'The Clone Wars' is a blue-skinned Duros known for his wide-brimmed hat?",
        answers = new[] { "Cad Bane", "Embo", "Bossk", "Aurra Sing" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Jedi homeworld often associated with the ancient Jedi Order in legends and some canon references?",
        answers = new[] { "Ilum", "Tython", "Ossus", "Ahch-To (sequel era, not used here as the correct answer)" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Clone Wars', what is the name of the trinary star system where embodiments of the Force (Father, Son, Daughter) reside?",
        answers = new[] { "Mortis", "Malachor", "Jedha", "Moraband" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which clone marshal commander leads the 212th Attack Battalion under Obi-Wan Kenobi?",
        answers = new[] { "Commander Cody", "Commander Bly", "Commander Gree", "Commander Fox" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "In 'The Mandalorian', what is the name of the planet where Din Djarin first meets Cara Dune?",
        answers = new[] { "Navarro", "Sorgan", "Tatooine", "Arvala-7" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Jedi Master appears as a disembodied voice and then a Force ghost guiding Luke in the original trilogy, after dying on the Death Star?",
        answers = new[] { "Yoda", "Mace Windu", "Qui-Gon Jinn", "Obi-Wan Kenobi" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Hard
    }
};

        var lotr = new List<QuestionData>
{
    // --------------------------------------------------------
    // LORD OF THE RINGS – EASY (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Who is the main hobbit tasked with destroying the One Ring?",
        answers = new[] { "Bilbo Baggins", "Frodo Baggins", "Samwise Gamgee", "Pippin Took" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the powerful object that must be destroyed to defeat Sauron?",
        answers = new[] { "The Palantír", "The Arkenstone", "The One Ring", "The Silmaril" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the dark lord seeking the One Ring?",
        answers = new[] { "Saruman", "Sauron", "Morgoth", "The Witch-king" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "In which peaceful region do hobbits like Frodo and Sam live?",
        answers = new[] { "Gondor", "Rohan", "Mordor", "The Shire" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which wizard guides the Fellowship and is known as 'the Grey' and later 'the White'?",
        answers = new[] { "Radagast", "Saruman", "Gandalf", "Alatar" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is Frodo's loyal gardener and friend?",
        answers = new[] { "Merry", "Pippin", "Samwise Gamgee", "Boromir" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which character often calls the Ring 'my precious'?",
        answers = new[] { "Gandalf", "Gollum / Sméagol", "Saruman", "Legolas" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of the dark land where Mount Doom is located?",
        answers = new[] { "Rohan", "Gondor", "Mordor", "The Shire" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which ranger is also known as 'Strider'?",
        answers = new[] { "Boromir", "Faramir", "Aragorn", "Éomer" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which Elf is a member of the Fellowship of the Ring?",
        answers = new[] { "Elrond", "Legolas", "Galadriel", "Arwen" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which Dwarf warrior is a member of the Fellowship?",
        answers = new[] { "Thorin Oakenshield", "Balin", "Gimli", "Dwalin" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which white wizard turns against the Free Peoples and allies with Sauron?",
        answers = new[] { "Gandalf", "Saruman", "Radagast", "Pallando" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What are the tree-like beings that live in Fangorn Forest called?",
        answers = new[] { "Orcs", "Balrogs", "Ents", "Nazgûl" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the white-walled capital city of Gondor?",
        answers = new[] { "Helm's Deep", "Minas Tirith", "Edoras", "Osgiliath" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the King of Rohan during the War of the Ring?",
        answers = new[] { "Denethor", "Elrond", "Théoden", "Isildur" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which fortress of Rohan is besieged by Saruman's Uruk-hai?",
        answers = new[] { "Minas Tirith", "Helm's Deep", "Dol Guldur", "Barad-dûr" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Which daughter of Elrond falls in love with Aragorn?",
        answers = new[] { "Éowyn", "Galadriel", "Arwen", "Tauriel" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What creatures rescue Frodo and Sam from the slopes of Mount Doom?",
        answers = new[] { "Eagles", "Ents", "Dragons", "Horses of Rohan" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "What is the name of Gandalf’s great horse?",
        answers = new[] { "Bill", "Shadowfax", "Snowmane", "Brego" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Who is the author of 'The Lord of the Rings' novels?",
        answers = new[] { "George R. R. Martin", "J. K. Rowling", "J. R. R. Tolkien", "C. S. Lewis" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },

    new QuestionData
{
    questionText = "What race is Frodo Baggins?",
    answers = new[] { "Man", "Hobbit", "Elf", "Dwarf" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "How many hobbits are part of the original Fellowship of the Ring?",
    answers = new[] { "2", "3", "4", "5" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is Frodo’s younger cousin and close friend who travels with him, full name?",
    answers = new[] { "Pippin Took", "Meriadoc Brandybuck", "Bilbo Baggins", "Fredegar Bolger" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is Pippin’s full first name?",
    answers = new[] { "Peregrin", "Pippard", "Perian", "Pelandor" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the title of the first part of 'The Lord of the Rings'?",
    answers = new[] { "The Two Towers", "The Return of the King", "The Fellowship of the Ring", "The Hobbit" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the title of the second part of 'The Lord of the Rings'?",
    answers = new[] { "The Two Towers", "The Fellowship of the Ring", "The Return of the King", "The Silmarillion" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the title of the third part of 'The Lord of the Rings'?",
    answers = new[] { "The Hobbit", "The Two Towers", "The Return of the King", "Unfinished Tales" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is Bilbo Baggins to Frodo?",
    answers = new[] { "His father", "His uncle/cousin", "His brother", "His grandfather" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the mine the Fellowship travels through after Caradhras?",
    answers = new[] { "Moria", "Angband", "Gundabad", "Nargothrond" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the inn in Bree where the hobbits meet Strider?",
    answers = new[] { "The Green Dragon", "The Prancing Pony", "The Golden Perch", "The Ivy Bush" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What race is Legolas?",
    answers = new[] { "Man", "Dwarf", "Elf", "Hobbit" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What race is Gimli?",
    answers = new[] { "Elf", "Man", "Dwarf", "Hobbit" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the fiery mountain where the One Ring must be destroyed?",
    answers = new[] { "Caradhras", "Mindolluin", "Mount Doom", "Amon Hen" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the eye that watches from the top of Barad-dûr?",
    answers = new[] { "The Eye of Sauron", "The Eye of Morgoth", "The Eye of Saruman", "The Red Eye" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the father of Boromir and Faramir?",
    answers = new[] { "Théoden", "Denethor", "Elendil", "Isildur" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which kingdom do Boromir and Faramir come from?",
    answers = new[] { "Rohan", "Gondor", "Mordor", "Dol Amroth" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which kingdom is famous for its horse-lords?",
    answers = new[] { "Gondor", "Rohan", "Mordor", "Harad" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the leader of the Nazgûl?",
    answers = new[] { "The Mouth of Sauron", "The Balrog", "The Witch-king of Angmar", "Gríma Wormtongue" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What creatures serve as Sauron’s great, flying mounts for the Nazgûl in the later films?",
    answers = new[] { "Great Eagles", "Fell beasts", "Dragons", "Griffins" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the Elven lord that hosts the Council where the fate of the Ring is decided?",
    answers = new[] { "Thranduil", "Celeborn", "Elrond", "Círdan" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the Elven lady who gives the Fellowship gifts in Lothlórien?",
    answers = new[] { "Arwen", "Galadriel", "Tauriel", "Lúthien" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which hobbit becomes the Mayor of the Shire later in life (books)?",
    answers = new[] { "Pippin", "Merry", "Samwise Gamgee", "Frodo Baggins" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the elf who rides with Aragorn and Gimli to the Paths of the Dead in the film?",
    answers = new[] { "Elrond", "Legolas", "Glorfindel", "Haldir" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What are the Black Riders most commonly called?",
    answers = new[] { "Orcs", "Nazgûl", "Balrogs", "Uruk-hai" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the Shire tavern often visited by hobbits like Frodo and Sam?",
    answers = new[] { "The Prancing Pony", "The Green Dragon", "The Ivy Bush", "The Pony’s Tail" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Who is the slimy advisor whispering in King Théoden’s ear before Gandalf frees him?",
    answers = new[] { "Gríma Wormtongue", "Háma", "Éomer", "Gamling" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which hobbit looks into the palantír and alerts Sauron in the films?",
    answers = new[] { "Frodo", "Sam", "Merry", "Pippin" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What is the name of the gigantic flying creatures ridden by the Nazgûl?",
    answers = new[] { "Eagles", "Fell beasts", "Dragons", "Mumakil" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "What are the enormous elephant-like creatures seen in battle called?",
    answers = new[] { "Mûmakil", "Wargs", "Drúedain", "Trolls" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Easy
},
new QuestionData
{
    questionText = "Which creature attacks the Fellowship outside the gates of Moria?",
    answers = new[] { "Shelob", "Watcher in the Water", "Balrog", "Fell beast" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Easy
},

    // --------------------------------------------------------
    // LORD OF THE RINGS – MEDIUM (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Who is Boromir's younger brother?",
        answers = new[] { "Faramir", "Théodred", "Éomer", "Haldir" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the Elven realm ruled by Galadriel and Celeborn?",
        answers = new[] { "Rivendell", "Lothlórien", "Mirkwood", "Valinor" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Bilbo and later Frodo's Elven-made sword?",
        answers = new[] { "Glamdring", "Andúril", "Sting", "Narsil" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Gandalf's sword, found in a troll hoard?",
        answers = new[] { "Glamdring", "Orcrist", "Sting", "Herugrim" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Who is the Steward of Gondor during the War of the Ring?",
        answers = new[] { "Isildur", "Denethor", "Théoden", "Ecthelion" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of the giant spider that attacks Frodo near Cirith Ungol?",
        answers = new[] { "Ungoliant", "Shelob", "Arachne", "Ungol" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What gift does Galadriel give Frodo in Lothlórien?",
        answers = new[] { "A golden belt", "A new sword", "The Light of Eärendil in a phial", "An Elven cloak" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "In which inn do the hobbits first meet Aragorn (Strider)?",
        answers = new[] { "The Green Dragon", "The Prancing Pony", "The Golden Perch", "The Ivy Bush" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What great river do the Fellowship travel down by boat after leaving Lothlórien?",
        answers = new[] { "Bruinen", "Anduin", "Isen", "Baranduin" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Elrond’s hidden valley?",
        answers = new[] { "Mirkwood", "Imladris", "Fangorn", "Eregion" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which shieldmaiden of Rohan helps defeat the Witch-king of Angmar?",
        answers = new[] { "Arwen", "Éowyn", "Galadriel", "Tauriel" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Sauron’s dark tower in Mordor?",
        answers = new[] { "Orthanc", "Barad-dûr", "Minas Morgul", "Dol Guldur" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Saruman’s black tower in Isengard?",
        answers = new[] { "Orthanc", "Barad-dûr", "Minas Tirith", "Cirith Ungol" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the capital city of Rohan?",
        answers = new[] { "Minas Tirith", "Edoras", "Helm's Deep", "Osgiliath" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Legolas is the prince of which woodland realm?",
        answers = new[] { "Lórien", "Mirkwood", "Rivendell", "Fangorn" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which river flows past the Shire and is crossed at Bucklebury Ferry?",
        answers = new[] { "Anduin", "Isen", "Brandywine", "Greyflood" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What is the name of Galadriel’s husband?",
        answers = new[] { "Elrond", "Celeborn", "Thranduil", "Gil-galad" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What special gift does Galadriel give Gimli?",
        answers = new[] { "An axe", "A golden belt", "Three strands of her hair", "An Elven bow" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Which fiery demon-like creature does Gandalf confront in Moria?",
        answers = new[] { "A Nazgûl", "A Balrog", "A Troll", "A Dragon" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "What blessed land across the sea do the Elves and Frodo eventually sail to?",
        answers = new[] { "Gondor", "Rohan", "The Undying Lands", "Numenor" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },

    new QuestionData
{
    questionText = "What is the Elvish name for Rivendell?",
    answers = new[] { "Imladris", "Lórien", "Eregion", "Gondolin" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the poisonous, addictive plant Saruman uses to fuel Isengard’s industry in the Shire (film version epilogue aside)?",
    answers = new[] { "Kingsfoil", "Longbottom Leaf", "Pipe-weed", "Athelas" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the great horn sounded in the fortress of the Hornburg at Helm’s Deep?",
    answers = new[] { "Horn of Gondor", "Horn of Helm Hammerhand", "Horn of Rohan", "Horn of Boromir" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the Men of Rohan’s own name for themselves in the books?",
    answers = new[] { "Rohirrim", "Eorlingas", "Dúnedain", "Edain" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "From which people does Aragorn descend, granting him long life and royal claim?",
    answers = new[] { "Haradrim", "Dúnedain of the North", "Drúedain", "Corsairs of Umbar" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the ruined city on the Anduin that once was the capital of Gondor?",
    answers = new[] { "Osgiliath", "Minas Anor", "Dol Amroth", "Anórien" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the Black Gate of Mordor?",
    answers = new[] { "Cirith Gorgor", "Morannon", "Udûn", "Dagorlad" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which hobbit first stabs the Witch-king’s knee at the Battle of the Pelennor Fields?",
    answers = new[] { "Frodo", "Sam", "Merry", "Pippin" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Éowyn’s brother, a key captain of the Rohirrim?",
    answers = new[] { "Éomer", "Erkenbrand", "Grimbold", "Háma" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which realm is ruled by Thranduil, Legolas’s father?",
    answers = new[] { "Lothlórien", "Mirkwood", "Rivendell", "Gondolin" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the ancient sword that belonged to Isildur and was later reforged for Aragorn?",
    answers = new[] { "Glamdring", "Narsil", "Herugrim", "Anglachel" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the ent who tells Merry and Pippin of the 'Entmoot'?",
    answers = new[] { "Quickbeam", "Beechbone", "Leaflock", "Skinbark" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who is known as the 'Mouth of Sauron' at the Black Gate?",
    answers = new[] { "A Nazgûl captain", "A corrupted Gondorian", "A Black Númenórean emissary", "A Ringwraith in disguise" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the healing plant that Aragorn uses to help Faramir and Éowyn?",
    answers = new[] { "Kingsfoil (Athelas)", "Elanor", "Simbelmynë", "Niphredil" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the Rohirrim fortress that stands in the valley of Harrowdale?",
    answers = new[] { "Dunharrow", "Helm’s Deep", "Edoras", "Isengard" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which creature drags Frodo into the Dead Marshes’ water?",
    answers = new[] { "Gollum", "A wraith-like corpse hand", "A marsh troll", "A giant eel" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who leads the Rangers that accompany Aragorn through the Paths of the Dead in the book?",
    answers = new[] { "Beregond", "Halbarad", "Damrod", "Anborn" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the pass in the Emyn Muil that Frodo and Sam must navigate before reaching the Black Gate?",
    answers = new[] { "Dunharrow", "Cirith Ungol", "The Marshes Pass", "The Stair of Cirith Ungol / winding path" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which shield does Éowyn carry into battle in the films?",
    answers = new[] { "A black Gondorian shield", "A golden Rohirrim shield", "A white tree shield", "A plain wooden shield" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of Faramir’s captain in the films who fights beside him in Osgiliath?",
    answers = new[] { "Beregond", "Damrod", "Madril", "Anborn" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which character lights the first beacon of Gondor in the films, calling for Rohan’s aid?",
    answers = new[] { "Pippin", "Merry", "Gandalf", "Faramir" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Who commands the Rohirrim forces at the Battle of the Pelennor Fields after Théoden falls?",
    answers = new[] { "Éomer", "Gandalf", "Aragorn", "Imrahil" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which group of Men does Aragorn recruit using the Army of the Dead to defeat the Corsairs?",
    answers = new[] { "Men of Gondor", "Men of Rohan", "The Grey Company", "The Haradrim" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the captain of the Ithilien Rangers who befriends Pippin in Minas Tirith (books)?",
    answers = new[] { "Beregond", "Damrod", "Anborn", "Imrahil" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the great stone city of the Dead under the Dwimorberg in the Paths of the Dead?",
    answers = new[] { "Minas Morgul", "Dunharrow", "The Stone of Erech", "The City of the Dead (unnamed in film; Erech as focal point)" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which Gondorian prince rides to the aid of Minas Tirith with knights from the coastal fiefdoms?",
    answers = new[] { "Prince Imrahil of Dol Amroth", "Denethor", "Forlong the Fat", "Húrin of the Keys" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the horse that Aragorn rides in Rohan in the films?",
    answers = new[] { "Brego", "Snowmane", "Hasufel", "Arod" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "Which ent leads the march on Isengard after the Entmoot?",
    answers = new[] { "Quickbeam", "Skinbark", "Beechbone", "Treebeard" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Medium
},
new QuestionData
{
    questionText = "What is the name of the creature type that Saruman breeds by crossing orcs with Men?",
    answers = new[] { "Goblins", "Uruk-hai", "Haradrim", "Corsairs" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Medium
},

    // --------------------------------------------------------
    // LORD OF THE RINGS – HARD (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "What is the name of the broken sword of Elendil that is later reforged for Aragorn?",
        answers = new[] { "Andúril", "Narsil", "Glamdring", "Herugrim" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "After being reforged, what new name is given to Narsil?",
        answers = new[] { "Glamdring", "Andúril", "Sting", "Orcrist" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What Elvish word, meaning 'friend', opens the Doors of Moria?",
        answers = new[] { "Mellon", "Mithrandir", "Mae govannen", "Mellonath" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What are the two great statues of Isildur and Anárion on the Anduin called?",
        answers = new[] { "Minas Anor", "The Argonath", "The Palantíri", "The Silmarils" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "By what other name is Treebeard known, which is also the Elvish name of his forest?",
        answers = new[] { "Oropher", "Fangorn", "Fimbrethil", "Nimrodel" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What were the nine human kings enslaved by Sauron collectively called?",
        answers = new[] { "Uruk-hai", "Nazgûl", "Haradrim", "Corsairs" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What was Minas Morgul called before it fell to the forces of Sauron?",
        answers = new[] { "Minas Anor", "Minas Ithil", "Osgiliath", "Dol Guldur" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who forges the three Elven Rings of Power?",
        answers = new[] { "Fëanor", "Celebrimbor", "Sauron", "Elrond" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which of the three Elven Rings does Galadriel bear?",
        answers = new[] { "Narya", "Vilya", "Nenya", "Aeglos" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the innkeeper at The Prancing Pony?",
        answers = new[] { "Barliman Butterbur", "Tom Bombadil", "Nob", "Robin Smallburrow" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of Théoden’s sword?",
        answers = new[] { "Andúril", "Herugrim", "Guthwine", "Narsil" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the pass above Minas Morgul that Frodo and Sam take into Mordor?",
        answers = new[] { "Cirith Ungol", "Caradhras", "Dunharrow", "Emyn Muil" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "On what battlefield outside Minas Tirith do the Riders of Rohan charge into Sauron’s armies?",
        answers = new[] { "Dagorlad", "The Pelennor Fields", "Fornost", "Nirnaeth Arnoediad" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Who kills Saruman in the extended edition of 'The Return of the King' film?",
        answers = new[] { "Gandalf", "Gríma Wormtongue", "Legolas", "Aragorn" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which Elf-lord leads the Elven warriors who aid at Helm's Deep in the film adaptation?",
        answers = new[] { "Glorfindel", "Haldir", "Thranduil", "Celeborn" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the book within the story that records the tales of Bilbo and Frodo?",
        answers = new[] { "The Red Book of Westmarch", "The Book of Lost Tales", "The Silmarillion", "The White Book of Arda" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "By what Sindarin name is Gandalf known among the Elves?",
        answers = new[] { "Mithrandir", "Curunír", "Olórin", "Incanus" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the Elvish name for Mount Doom, where the Ring is destroyed?",
        answers = new[] { "Orodruin", "Ered Nimrais", "Caradhras", "Mindolluin" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Which ancient kingdom of Men, now sunk beneath the sea, is often referenced as the origin of Aragorn’s lineage?",
        answers = new[] { "Gondor", "Rohan", "Numenor", "Arnor" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "What is the name of the Elvish realm in the north where Elrond is Lord?",
        answers = new[] { "Imladris (Rivendell)", "Lothlórien", "Mirkwood", "Beleriand" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },

    new QuestionData
{
    questionText = "What was Gandalf’s name in Valinor before he came to Middle-earth?",
    answers = new[] { "Olórin", "Mithrandir", "Curunír", "Eönwë" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the Sindarin word for 'Elf-friend', used as a title for some Men?",
    answers = new[] { "Mellon", "Perian", "Elendil", "Nimrais" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which of the following is NOT one of the Three Elven Rings?",
    answers = new[] { "Narya", "Vilya", "Nenya", "Angrist" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who was the last King of Gondor before the line of kings failed and the Stewards ruled?",
    answers = new[] { "Eärnur", "Ecthelion I", "Isildur", "Arvedui" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Númenórean kingdom in exile lay in the north of Middle-earth before it fell?",
    answers = new[] { "Gondor", "Rohan", "Arnor", "Dol Amroth" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the great wolf that attacks the Fellowship at the West-gate of Moria in the book?",
    answers = new[] { "Carcharoth", "Draugluin", "The Wolf of Angmar", "The Watcher is used instead; wolf appears differently in text" },
    correctIndex = 3,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the hill outside Minas Tirith where the beacons of Gondor are first lit?",
    answers = new[] { "Minas Anor", "Amon Dîn", "Amon Sûl", "Amon Hen" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which Maiar spirit is believed to have become the Balrog that Gandalf fights?",
    answers = new[] { "Gothmog", "Durin’s Bane (unnamed Balrog)", "Sauron himself", "Ungoliant" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What secret name do the Dwarves use for Moria?",
    answers = new[] { "Khazad-dûm", "Belegost", "Nogrod", "Zirakzigil" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "On which mountain peak does Gandalf confront the Balrog after falling from the Bridge of Khazad-dûm?",
    answers = new[] { "Caradhras", "Zirakzigil", "Mindolluin", "Amon Rûdh" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the ancient sword of the Elven-king Turgon that later passes into Gondolin’s tales, though not directly seen in LotR?",
    answers = new[] { "Gurthang", "Ringil", "Glamdring", "Aeglos" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who was the original bearer of the Ring of Fire, Narya, before Gandalf received it?",
    answers = new[] { "Elrond", "Círdan the Shipwright", "Galadriel", "Gil-galad" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which river forms the eastern border of the Shire?",
    answers = new[] { "Anduin", "Brandywine (Baranduin)", "Greyflood", "Isen" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the old forest near the Shire where Tom Bombadil lives?",
    answers = new[] { "Fangorn Forest", "Mirkwood", "The Old Forest", "Eryn Vorn" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which being rescues the hobbits from Old Man Willow in the book?",
    answers = new[] { "Gandalf", "Tom Bombadil", "Radagast", "Glorfindel" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What was Gollum’s original name before he found the Ring?",
    answers = new[] { "Déagol", "Sméagol", "Drogo", "Lotho" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which of the following is NOT one of the palantíri’s known locations in the Third Age?",
    answers = new[] { "Minas Tirith", "Isengard", "Edoras", "Orthanc and Barad-dûr share stones" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the hill in the Shire from which Gandalf’s fireworks are often launched?",
    answers = new[] { "Bagshot Row", "The Party Field", "Green Hill", "The Hill of Hobbiton" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which noble house of Gondor rules the coastal city of Dol Amroth?",
    answers = new[] { "House of Húrin", "House of Imrahil", "House of Eorl", "House of Elendil" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which pre-historic Dark Lord came before Sauron and corrupted him?",
    answers = new[] { "Morgoth (Melkor)", "Gothmog", "Ungoliant", "Ancalagon" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the pass over the Misty Mountains that the Fellowship attempts before turning to Moria?",
    answers = new[] { "Caradhras", "Zirakzigil", "Celebdil", "Fanuidhol" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "In the book, who actually kills the chief Orc Uglúk after the raid at Amon Hen and the chase across Rohan?",
    answers = new[] { "Éomer and his Riders", "Aragorn", "Gimli", "Legolas" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which mountain lies behind Helm’s Deep and the Hornburg?",
    answers = new[] { "Mindolluin", "Starkhorn", "Thrihyrne", "Celebdil" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the chief of the Haradrim who challenges Théoden’s riders in the books?",
    answers = new[] { "The Black Serpent", "The Red Harad", "The Mumak-lord", "The Southron Captain" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which of these is the Elvish name for the White Mountains of Gondor?",
    answers = new[] { "Ered Nimrais", "Ered Mithrin", "Ered Luin", "Ered Gorgoroth" },
    correctIndex = 0,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "What is the name of the hidden door into the Lonely Mountain in 'The Hobbit', later referenced in the wider legendarium?",
    answers = new[] { "The Durin Door", "The Back Door", "The Secret Gate", "The Door of Erebor" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which character speaks the line 'I am no man' before slaying the Witch-king?",
    answers = new[] { "Galadriel", "Éowyn", "Arwen", "Tauriel" },
    correctIndex = 1,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Which hobbit leads the Scouring of the Shire in the book after returning from the War of the Ring?",
    answers = new[] { "Frodo", "Sam", "Merry", "Pippin" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
},
new QuestionData
{
    questionText = "Who becomes the Thain of the Shire after the events of the War of the Ring (books)?",
    answers = new[] { "Samwise Gamgee", "Meriadoc Brandybuck", "Peregrin Took", "Frodo Baggins" },
    correctIndex = 2,
    difficulty = QuestionDifficulty.Hard
}
};

        var muhtesemYuzyil = new List<QuestionData>
{
    // --------------------------------------------------------
    // MUHTEÞEM YÜZYIL – EASY (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Dizide Kanuni Sultan Süleyman’ý canlandýran oyuncu kimdir?",
        answers = new[] { "Kývanç Tatlýtuð", "Halit Ergenç", "Burak Özçivit", "Kenan Ýmirzalýoðlu" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide Hürrem Sultan’ýn asýl adý nedir?",
        answers = new[] { "Anastasia", "Roksalana / Aleksandra", "Leyla", "Nurbanu" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn padiþahý ilk gördüðü yer neresidir?",
        answers = new[] { "Topkapý Sarayý bahçesi", "Hamam", "Harem’in avlusu", "Divan toplantýsý" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Kanuni Sultan Süleyman’ýn annesi kimdir?",
        answers = new[] { "Hürrem Sultan", "Mahidevran Sultan", "Valide Sultan Ayþe Hafsa", "Nurbanu Sultan" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Harem’in baþýndaki kadýn hangi unvanla anýlýr?",
        answers = new[] { "Hatunbaþý", "Ustuna", "Valide Sultan", "Kadýn Efendi" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn ilk doðan oðlu kimdir?",
        answers = new[] { "Mehmet", "Selim", "Bayezid", "Mustafa" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Mahidevran Sultan’ýn oðlu kimdir?",
        answers = new[] { "Þehzade Mustafa", "Þehzade Selim", "Þehzade Bayezid", "Þehzade Cihangir" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Süleyman’ýn çocukluk arkadaþý ve sadrazam olan karakter kimdir?",
        answers = new[] { "Rüstem Paþa", "Ýbrahim Paþa", "Lütfi Paþa", "Pargalý Sinan" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn lakabý nedir?",
        answers = new[] { "Pargalý", "Maktul", "Sofu", "Koca" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizinin büyük kýsmý hangi sarayda geçmektedir?",
        answers = new[] { "Dolmabahçe Sarayý", "Beylerbeyi Sarayý", "Topkapý Sarayý", "Yýldýz Sarayý" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn en büyük rakibi kimdir?",
        answers = new[] { "Nurbanu Sultan", "Gülfem Hatun", "Mahidevran Sultan", "Þah Sultan" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Kanuni’nin batýdaki en ünlü seferlerinden biri hangi kaleye yapýlmýþtýr?",
        answers = new[] { "Belgrad", "Kafkasya", "Ýskenderiye", "Baðdat" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide Hürrem Sultan’ýn yüzündeki en belirgin özellik nedir?",
        answers = new[] { "Yara izi", "Çil", "Ben", "Dövme" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Saraydaki cariyelerin eðitildiði bölüm hangi isimle anýlýr?",
        answers = new[] { "Enderun", "Harem", "Divanhane", "Has Oda" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn evlendiði padiþah kýzý kimdir?",
        answers = new[] { "Mihrimah Sultan", "Þah Sultan", "Hatice Sultan", "Fatma Sultan" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Mihrimah Sultan’ýn babasý kimdir?",
        answers = new[] { "Yavuz Sultan Selim", "Kanuni Sultan Süleyman", "II. Bayezid", "III. Murad" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide Mustafa karakteri hangi unvanla anýlýr?",
        answers = new[] { "Þehzade", "Sultan", "Bey", "Paþa" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn en yakýn cariye dostlarýndan biri kimdir?",
        answers = new[] { "Gülfem Hatun", "Gülnuþ", "Daye Hatun", "Nigar Kalfa" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Sarayda padiþahýn resmî toplantý yaptýðý meclise ne ad verilir?",
        answers = new[] { "Þûra", "Meclis-i Mebusan", "Divan-ý Hümayun", "Saray Divaný" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn saç rengi dizide nasýldýr?",
        answers = new[] { "Siyah", "Kýzýl / kýzýl kahve", "Sarý", "Kahverengi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide Kanuni’nin babasý Yavuz Sultan Selim’den sýk sýk nasýl bahsedilir?",
        answers = new[] { "Merhametli", "Sürgün", "Fetihçi ve sert", "Korkak" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Þehzadelerin sancak beyi olarak gönderildiði þehirlere genel olarak ne ad verilir?",
        answers = new[] { "Kaza", "Sancak", "Liva", "Köy" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide Kanuni’nin en güvendiði yeniçeri aðalarýndan biri kimdir?",
        answers = new[] { "Sümbül Aða", "Gazanfer Aða", "Ayaz Aða", "Ali Aða" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Mihrimah Sultan’ýn annesi kimdir?",
        answers = new[] { "Mahidevran", "Hürrem Sultan", "Nurbanu", "Gülfem Hatun" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide, sarayýn baþmimarýný temsil eden karakter hangi ünlü tarihî kiþiliðe dayanýr?",
        answers = new[] { "Mimar Hayreddin", "Mimar Davud", "Mimar Sinan", "Mimar Koca Kasým" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn saraya getirildiði bölge neresi olarak anlatýlýr?",
        answers = new[] { "Rus stepleri / Lehistan civarý", "Kafkasya", "Balkanlar", "Arap Yarýmadasý" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn sonu nasýl olur?",
        answers = new[] { "Sürgün edilir", "Ýdam edilir", "Kendi isteðiyle ayrýlýr", "Savaþta ölür" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’nýn babasý kimdir?",
        answers = new[] { "Yavuz Sultan Selim", "Kanuni Sultan Süleyman", "II. Bayezid", "II. Selim" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’nýn annesi kimdir?",
        answers = new[] { "Hürrem Sultan", "Mahidevran Sultan", "Nurbanu Sultan", "Fatma Sultan" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide en sýk görülen ulaþým aracý aþaðýdakilerden hangisidir?",
        answers = new[] { "Araba", "Gemi", "At", "Uçak" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide sarayýn temel eðlence unsurlarýndan biri aþaðýdakilerden hangisidir?",
        answers = new[] { "Tiyatro oyunu", "Þiir ve müzik meclisleri", "Sinema", "Futbol" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem’in padiþahý etkilemek için en sýk kullandýðý þeylerden biri nedir?",
        answers = new[] { "Savaþ becerisi", "Siyasi tehdit", "Güzelliði ve zekâsý", "Mali güç" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Haremde cariyelere gözetmenlik eden ve düzen saðlayan kadýnlara genel olarak ne denir?",
        answers = new[] { "Kalfa", "Nedime", "Sultan", "Hatun" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide saray dýþý sahnelerde en sýk görülen mekânlardan biri hangisidir?",
        answers = new[] { "Çarþý / pazar", "Maden ocaðý", "Kale zindaný", "Deniz feneri" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem’in padiþahýn gözünde yükselmesini saðlayan en önemli unsur nedir?",
        answers = new[] { "Aþçýlýk yeteneði", "Siyasî evlilik", "Onun çocuklarýnýn annesi olmasý", "Yabancý elçi olmasý" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide 'Sultan’ ifadesi genelde kimler için kullanýlmaktadýr?",
        answers = new[] { "Yalnýzca padiþah için", "Sadece vezirler için", "Hanedan üyeleri için", "Yeniçeriler için" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’nýn sýkça görüldüðü sancak þehri hangisidir?",
        answers = new[] { "Manisa", "Amasya", "Kütahya", "Trabzon" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Kanuni’nin meþhur lakaplarýndan biri aþaðýdakilerden hangisidir?",
        answers = new[] { "Yýldýrým", "Fatih", "Kanuni", "Yavuz" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Sarayda padiþaha yemek servisi yapan bölüme ne ad verilir?",
        answers = new[] { "Matbah-ý Amire", "Ahýr-ý Hümayun", "Defterdar Ocaðý", "Darphane" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide Kanuni’ye sýk sýk eþlik eden þair kimdir?",
        answers = new[] { "Fuzuli", "Baki", "Yahya Efendi", "Nefi" },
        correctIndex = 1, // Baki karakteriyle sýk atýf
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn saraydaki statüsü ilk baþta nedir?",
        answers = new[] { "Valide Sultan", "Cariyelerden biri", "Baþkadýn", "Hatunbaþý" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Sarayda eðlence için düzenlenen bazen maskeli, müzikli gece toplantýlarýna genel olarak ne denir?",
        answers = new[] { "Þölen", "Ziyafet", "Eðlence Meclisi", "Musiki Meclisi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Kanuni’nin, Hürrem’e olan sevgisi dizide genel olarak nasýl betimlenmektedir?",
        answers = new[] { "Ilgýsýz", "Zorunlu evlilik", "Büyük bir aþk", "Sadece siyasi bað" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Saray dýþýndaki halk sahnelerinde en çok hangi sosyal sýnýf görülür?",
        answers = new[] { "Askerler ve esnaflar", "Madenciler", "Denizciler", "Çobanlar" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Mihrimah Sultan’ýn küçük yaþta görüldüðü sahnelerde en çok kiminle olduðu gösterilir?",
        answers = new[] { "Mahidevran", "Valide Sultan", "Hürrem ve Süleyman", "Nigar Kalfa" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },
    new QuestionData
    {
        questionText = "Dizide padiþahýn mektuplarýný yazan, kalem iþlerinden sorumlu kiþiler hangi sýnýfa girer?",
        answers = new[] { "Yeniçeri", "Defterdar", "Reisülküttap / kâtipler", "Sipahi" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Easy
    },

    // --------------------------------------------------------
    // MUHTEÞEM YÜZYIL – MEDIUM (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn asýl memleketi diziye göre neresidir?",
        answers = new[] { "Arnavutluk / Parga", "Bosna", "Macaristan", "Kýrým" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa'nýn sarayda ilk görevi neydi?",
        answers = new[] { "Baþmimar", "Hazinedarbaþý", "Padiþahýn has oda görevlisi / silahtar", "Defterdar" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide, Valide Sultan ile en çok çekiþen kadýn karakter kimdir?",
        answers = new[] { "Gülfem Hatun", "Mahidevran", "Hürrem Sultan", "Þah Sultan" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn, Mahidevran ile en aðýr kavgalardan birini yaþadýðý yer neresidir?",
        answers = new[] { "Hamam", "Harem avlusu", "Valide odasý", "Saray mutfaðý" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’nýn idamýna giden süreçte, Hürrem ile iþbirliði yaptýðý gösterilen devlet adamý kimdir?",
        answers = new[] { "Lütfi Paþa", "Rüstem Paþa", "Ýbrahim Paþa", "Hadým Süleyman Paþa" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Rüstem Paþa hangi sultanla evlenerek sarayda gücünü artýrmýþtýr?",
        answers = new[] { "Mihrimah Sultan", "Hatice Sultan", "Þah Sultan", "Fatma Sultan" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Mihrimah Sultan’ýn, babasý için yaptýrdýðý ünlü cami dizide hangi þehirde anýlýr?",
        answers = new[] { "Edirne", "Manisa", "Ýstanbul", "Bursa" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide Þehzade Mustafa’nýn orduda en çok sevildiði kesim kimler olarak gösterilir?",
        answers = new[] { "Sipahiler", "Yeniçeriler", "Leventler", "Azaplar" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Mahidevran Sultan, Þehzade Mustafa’nýn ölümünden sonra nereye çekilir?",
        answers = new[] { "Manisa", "Bursa", "Amasya", "Trabzon" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn en büyük oðullarýndan biri olan Þehzade Selim ileride hangi lakapla padiþah olur?",
        answers = new[] { "Sarhoþ Selim", "Yavuz Selim", "Kanuni Selim", "Genç Selim" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn saraya geldiði ilk dönemde en çok bað kurduðu kiþilik kimdir?",
        answers = new[] { "Mahidevran", "Valide Sultan", "Süleyman", "Hürrem" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn sarayda gizli planlarýný sýkça paylaþtýðý, akýl aldýðý kadýn karakter kimdir?",
        answers = new[] { "Daye Hatun", "Gülfem Hatun", "Nigar Kalfa", "Firuze" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide, Kanuni’nin mektuplaþtýðý Avrupalý kadýn hükümdar kim olarak sunulur?",
        answers = new[] { "Kraliçe Elizabeth", "Fransýz Kraliçesi", "Avusturya Arþidüþesi", "Macar Kraliçesi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Sarayýn önemli hadýmlarýndan Sümbül Aða hangi bölümle daha çok ilgilenir?",
        answers = new[] { "Enderun", "Harem", "Matbah", "Tersane" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide Ýbrahim Paþa, hangi büyük unvana yükseldikten sonra daha da kibirli davranmaya baþlar?",
        answers = new[] { "Beylerbeyi", "Sadrazam", "Kaptan-ý Derya", "Defterdar" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem’in gözdesi olan ve sonrasýnda önemli bir mevkiye yükselen cariye kimdir?",
        answers = new[] { "Gülfem", "Nurbanu", "Firuze", "Raziye" },
        correctIndex = 1, // Nurbanu daha sonraki dönem için bað
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Þehzade Bayezid hangi özelliðiyle dizide ön plana çýkar?",
        answers = new[] { "Çok sakin ve aðýrbaþlý", "Açýkça isyankâr ve hýrslý", "Dindar ve içe kapanýk", "Savaþtan korkan" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Þehzade Cihangir’in fiziksel rahatsýzlýðý dizide nasýl gösterilir?",
        answers = new[] { "Gözü görmüyor", "Kolu yok", "Kamburlu", "Bacaðý sakat" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Cihangir’in, Mustafa’nýn ölümünden sonra yaþadýðý durum dizide nasýl yansýtýlýr?",
        answers = new[] { "Sürgün olur", "Daha da güçlenir", "Derin bir çöküþ ve hastalýk", "Evlenir ve ayrýlýr" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Mihrimah Sultan’ýn aþký olarak dizide öne çýkan karakter kimdir?",
        answers = new[] { "Bali Bey", "Mimar Sinan", "Rüstem Paþa", "Þehzade Mustafa" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Bali Bey’in mesleði / konumu dizide hangisine daha yakýndýr?",
        answers = new[] { "Sarraf", "Sipahi / akýncý kumandaný", "Kaptan-ý Derya", "Defterdar" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn portre yaptýrma sahneleri hangi özelliðini öne çýkarýr?",
        answers = new[] { "Dindarlýðýný", "Gurur ve kibirini", "Cimriliðini", "Savaþçýlýðýný" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan ile Ýbrahim Paþa arasýndaki düþmanlýk daha çok neye dayanýr?",
        answers = new[] { "Para kavgasý", "Aþk üçgeni", "Güç ve nüfuz mücadelesi", "Aile husumeti" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide, Kanuni’nin en önemli doðu seferlerinden biri hangi þehre yöneliktir?",
        answers = new[] { "Baðdat", "Þam", "Tebriz", "Kahire" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’nýn öldürülmesi hangi sefer sýrasýnda gerçekleþir?",
        answers = new[] { "Belgrad Seferi", "Rodos Seferi", "Nahçývan / Ýran Seferi", "Nahçývan sonrasý Konya civarý" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide casusluk faaliyetleri için kullanýlan, Avrupa ile baðlantý kuran karakterlerden biri kimdir?",
        answers = new[] { "Hüsrev Aða", "Ýskender Çelebi", "Nigar Kalfa", "Ýsabella Fortuna / Victoria vb." },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Divan-ý Hümayun toplantýlarýnda padiþahýn oturduðu yer dizide nasýl gösterilir?",
        answers = new[] { "Herkesle ayný masa", "Perde arkasýndan izler", "Divan dýþýnda baþka odada", "Ayakta durur" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Rüstem Paþa’nýn en çok eleþtirilen özelliði nedir?",
        answers = new[] { "Aþýrý cömertlik", "Hýrs ve entrikacýlýk", "Sessizlik", "Savaþta korkaklýk" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Mihrimah ile Rüstem Paþa evliliði dizide nasýl sunulur?",
        answers = new[] { "Büyük bir aþk evliliði", "Tamamen siyasî evlilik", "Kaza sonucu evlilik", "Zorunlu sürgün evliliði" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem, saray içindeki mektuplaþmalarý takip etmek için en çok kimden faydalanýr?",
        answers = new[] { "Sümbül Aða", "Nigar Kalfa", "Balýkçý", "Mimar Sinan" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Mahidevran’ýn saraydaki nüfuzunu kaybetmesindeki en önemli etken nedir?",
        answers = new[] { "Para kaybý", "Oðluyla uzak sancakta kalmasý", "Valide ile kavgasý", "Hürrem’in çocuklarýnýn artmasý" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Mihrimah’ýn Bali Bey’e duyduðu aþk, dizide nasýl bir sonuçla neticelenir?",
        answers = new[] { "Evlenirler", "Kaçarlar", "Asla kavuþamazlar", "Bali Bey ölür" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Bayezid ile Selim’in çekiþmesi hangi tema üzerinden daha çok ilerler?",
        answers = new[] { "Aþk", "Din", "Taht ve veliahtlýk", "Para" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide Hürrem’in, Valide Sultan’ýn ölümünden sonra saraydaki rolü nasýl deðiþir?",
        answers = new[] { "Saraydan uzaklaþtýrýlýr", "Valide konumuna yükselir", "Enderun’a alýnýr", "Hiç deðiþmez" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Dizide, Þah Sultan hangi yönden Hürrem’e karþý durur?",
        answers = new[] { "Askerî açýdan", "Mali konularda", "Aile ve harem politikasý açýsýndan", "Dýþ siyaset" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn sarayda sýkça görülen özel odasý aþaðýdakilerden hangisidir?",
        answers = new[] { "Silah odasý", "Harita ve resim odasý", "Hazinedar odasý", "Kütüphane" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Hürrem’in rakiplerine karþý en çok kullandýðý yöntemlerden biri nedir?",
        answers = new[] { "Doðrudan fiziksel saldýrý", "Zehrin ima edilmesi, iftira ve entrika", "Saraydan kaçma", "Savaþ açma" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn öldürülmesi kararý Kanuni’de hangi duyguyu en çok ön plana çýkarýr?",
        answers = new[] { "Rahatlama", "Derin piþmanlýk ve hüzün", "Sevinç", "Korku" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Medium
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’nýn idam sahnesinde, ordu ve halkýn tavrý nasýl yansýtýlýr?",
        answers = new[] { "Sevinç", "Umursamazlýk", "Þok ve öfke", "Hiç haberdar olmazlar" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Medium
    },

    // --------------------------------------------------------
    // MUHTEÞEM YÜZYIL – HARD (50)
    // --------------------------------------------------------
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn tam unvaný aþaðýdakilerden hangisine en yakýndýr?",
        answers = new[] { "Damat Ýbrahim Paþa, Makbul/Maktul Ýbrahim", "Hacý Ýbrahim Aða", "Kaptan-ý Derya Ýbrahim", "Defterdar Ýbrahim Efendi" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide, Ýbrahim Paþa’nýn düþüþüne neden olan en önemli dýþ politika hamlesi nedir?",
        answers = new[] { "Macaristan’a tek baþýna sefer açmasý", "Kendini sanki eþ hükümdar gibi göstermesi", "Baðdat’ý terk etmesi", "Venedik’le gizli anlaþma yapmasý" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Valide Sultan Ayþe Hafsa’nýn hastalýðý sýrasýnda sarayda ortaya çýkan en büyük kriz nedir?",
        answers = new[] { "Haremde isyan", "Hürrem ile Mahidevran arasýndaki kavganýn büyümesi", "Yeniçeri ayaklanmasý", "Savaþ ilaný" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Nigar Kalfa’nýn dramý hangi olay üzerinden doruða ulaþýr?",
        answers = new[] { "Zehirlenmesi", "Ölü doðum", "Ýbrahim’den hamile kalmasý", "Sürgün edilmesi" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide, Hürrem’in Avrupa siyasetinde etkili olma çabalarý hangi elçi/karakter üzerinden sýkça gösterilir?",
        answers = new[] { "Avusturya elçisi", "Fransýz elçisi", "Venedik bailosu", "Ýspanyol elçisi" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Þehzade Mustafa’ya karþý düzenlenen iftira ve sahte mektup operasyonunda kimin imzasý taklit edilir?",
        answers = new[] { "Valide Sultan", "Ýbrahim Paþa", "Þehzade Mehmet", "Þah Tahmasb" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Kanuni’nin en uzun süreli seferlerinden biri hangi coðrafyaya yöneliktir?",
        answers = new[] { "Mohaç ovasý", "Irakeyn / Baðdat ve çevresi", "Rodos adasý", "Kýbrýs seferi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Hürrem’in, Mihrimah üzerinden Rüstem Paþa’yý kontrol etmesinin en önemli sonucu nedir?",
        answers = new[] { "Hazineyi ele geçirmesi", "Þehzade Mustafa’ya karþý güçlenmesi", "Ordunun baþýna geçmesi", "Valide’yi sürgüne göndermesi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Þehzade Bayezid’in isyaný dizide hangi þehirle iliþkili olarak sýk sýk anýlýr?",
        answers = new[] { "Kütahya", "Amasya", "Konya", "Sivas" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Bayezid’in Selim’e yenik düþerek Ýran’a sýðýnmasý hangi büyük tarihî þahsiyete gönderme yapar?",
        answers = new[] { "Þah Ýsmail", "Þah Tahmasb", "Þah Abbas", "Nadir Þah" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Mimar Sinan karakteri ilk ortaya çýktýðýnda hangi görevle anýlýr?",
        answers = new[] { "Ordu mimarý", "Küçük bir taþ ustasý", "Yeniçeri", "Donanma mimarý" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Hatice Sultan’ýn Ýbrahim Paþa’ya olan aþký dizide hangi sahneyle sembolleþir?",
        answers = new[] { "Deniz kýyýsýndaki vedalarý", "Mehtapta kýlýç talimi", "Portre sahneleri", "Mektup yakma sahnesi" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Ýbrahim Paþa’nýn 'Makbul’den 'Maktul’e dönüþme sürecinde Kanuni’ye karþý hangi sözleri büyük kýrýlma yaratýr?",
        answers = new[] { "\"Benim de senin kadar hakkým var\" minvali sözler", "Devleti býrakma tehdidi", "Hürrem’e sahip çýkma sözü", "Valide’yi suçlamasý" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Hürrem Sultan’ýn saray içinde yaptýrdýðý hayýr iþlerindeki en önemli yapýlarýndan biri hangisidir?",
        answers = new[] { "Haseki Külliyesi", "Mihrimah Camii", "Fatih Camii", "Süleymaniye Medresesi" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Þah Sultan’ýn kocasý olarak gösterilen kiþi hangi eyaletle baðlantýlý bir beylerbeyi tipidir?",
        answers = new[] { "Anadolu", "Rumeli", "Karaman", "Diyarbakýr" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Valide Sultan Ayþe Hafsa’nýn ölümü sonrasý ortaya çýkan en büyük boþluk hangi alandadýr?",
        answers = new[] { "Askere kumanda", "Harem içi otorite ve denge", "Maliye", "Donanma" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Hürrem’in en büyük korkularýndan biri aþaðýdakilerden hangisidir?",
        answers = new[] { "Saraydan kovulmak", "Çocuklarýnýn öldürülmesi", "Hazineyi kaybetmek", "Yabancý ülkeye sürgün" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Þehzade Cihangir’in ölümü dizide hangi olaydan hemen sonra gösterilir?",
        answers = new[] { "Ýbrahim’in ölümü", "Mustafa’nýn idamý", "Valide’nin ölümü", "Hürrem’in ölümü" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Rüstem Paþa’nýn görevden alýnmasýna sebep olan en önemli kriz nedir?",
        answers = new[] { "Hazineyi boþaltmasý", "Mustafa meselesinde suçlanmasý", "Sarayda yangýn", "Deniz savaþýný kaybetmesi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Mihrimah Sultan’ýn, babasýna gönderdiði mektuplarda en çok vurguladýðý mesele nedir?",
        answers = new[] { "Bayezid-Selim kavgasý", "Harem düzeni", "Valide ile sorunlar", "Ýbrahim Paþa anýlarý" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Mihrimah ile Mimar Sinan arasýnda ima edilen duygusal bað hangi açýdan gösterilir?",
        answers = new[] { "Açýk aþk ilaný", "Sadece bakýþlar ve eserler üzerinden", "Savaþ sahneleriyle", "Harem toplantýlarýyla" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Þehzade Selim’in karakteri dizide hangi zaaf üzerinden inþa edilmiþtir?",
        answers = new[] { "Ýçki ve eðlence düþkünlüðü", "Aþýrý cimrilik", "Sürekli savaþ isteði", "Aþýrý dindarlýk" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Bayezid’in Ýran’a sýðýndýktan sonra akýbeti nasýl gösterilir?",
        answers = new[] { "Affedilir", "Tahta çýkarýlýr", "Þah tarafýndan teslim edilerek öldürülür", "Sürgünde yaþar" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Hürrem’in ölüm sahnesi nasýl bir atmosferde gerçekleþir?",
        answers = new[] { "Savaþ alanýnda", "Yalnýz bir odada, hastalýk ve yorgunlukla", "Denizde fýrtýnada", "Zehirlenerek" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Kanuni’nin dizide son seferi olarak hangi sefer ön plana çýkmaktadýr?",
        answers = new[] { "Rodos", "Mohaç", "Sigetvar", "Baðdat" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Kanuni’nin, ömrünün son dönemlerinde en çok kimin yokluðunu hissettiði vurgulanýr?",
        answers = new[] { "Valide Sultan", "Ýbrahim Paþa ve Hürrem", "Rüstem Paþa", "Mihrimah" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Ýbrahim Paþa’nýn idamý nerede gerçekleþtirilir?",
        answers = new[] { "Topkapý Sarayý bahçesi", "Hipodrom / At Meydaný yakýnlarý", "Boðaziçi kýyýsý", "Zindan içi" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Mahidevran’ýn, Mustafa’nýn ölümünden sonra sarayla baðýnýn kopuþu hangi sahneyle sembolleþir?",
        answers = new[] { "Saray kapýsýndan çýkarýlmasý", "Mektuplarýnýn yakýlmasý", "Mücevherlerinin alýnmasý", "Baþörtüsünün çýkarýlmasý" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide, saray içi hiyerarþide Valide’den sonra haremde söz sahibi olan konum hangisidir?",
        answers = new[] { "Baþkadýn / Baþ Haseki", "Kalfa", "Cariyebaþý", "Usta" },
        correctIndex = 0,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Hürrem’in Firuze ile olan çekiþmesi hangi ana tema etrafýnda döner?",
        answers = new[] { "Para", "Siyaset", "Süleyman’ýn gönlünü paylaþamama", "Savaþ" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide Þah Sultan’ýn Hürrem’e karþý kullandýðý en güçlü koz nedir?",
        answers = new[] { "Valide ile akrabalýk baðý", "Ýbrahim Paþa üzerindeki etkisi", "Mustafa ile yakýnlýðý", "Maliye üzerindeki gücü" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Nigar Kalfa’nýn son sahnelerinde en çok hangi duygu ön plandadýr?",
        answers = new[] { "Ýntikam hýrsý", "Teslim olmuþluk ve kýrgýnlýk", "Sevinç", "Umursamazlýk" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Mihrimah’ýn, babasýna savaþ ve siyaset üstüne yazdýðý mektuplar hangi özelliðini gösterir?",
        answers = new[] { "Cahil olduðunu", "Sadece aþk düþündüðünü", "Siyasî zekâ ve cesaretini", "Hiç fikri olmadýðýný" },
        correctIndex = 2,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizide, Kanuni’nin þiir yazarken kullandýðý mahlas hangisidir?",
        answers = new[] { "Necati", "Fuzuli", "Baki", "Muhibbi" },
        correctIndex = 3,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Hürrem’in saraydaki en uzun vadeli planlarýndan biri hangi hedefe yöneliktir?",
        answers = new[] { "Mustafa’yý tahta geçirmek", "Kendi oðullarýndan birini padiþah yapmak", "Saraydan kaçmak", "Valide’yi öldürmek" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    },
    new QuestionData
    {
        questionText = "Dizinin genel kurgusunda en baskýn iki ana eksen hangi temalara dayanýr?",
        answers = new[] { "Savaþ ve ekonomi", "Aþk ve siyaset", "Din ve felsefe", "Bilim ve keþif" },
        correctIndex = 1,
        difficulty = QuestionDifficulty.Hard
    }
};
        
        
        questionBank[CategoryType.MuhtesemYuzyil] = muhtesemYuzyil;
        questionBank[CategoryType.StarWars] = starWars;
        questionBank[CategoryType.LordOfTheRings] = lotr;
        questionBank[CategoryType.GameOfThrones] = got;
        questionBank[CategoryType.HarryPotter] = hp;

        return questionBank;
    }
}
