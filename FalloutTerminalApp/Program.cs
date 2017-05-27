using System;

namespace FalloutTerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] words = new string[][] { 
                new string[] { },
                new string[] { "A" }, 
                new string[] { "PC", "TO", "BE", "AS", "OF", "IN", "IS", "AT", "HE", "BY", "AI", "AN", "SO", "IT", "ON", "IF", "OR", "GO", "NO", "UP" },
                new string[] { "THE", "FOR", "HIS", "HAS", "AND", "WHO", "ACT", "WAY", "CAN", "HIM", "ITS", "OWN", "MAY", "ALL", "PCS", "ARE", "END", "OFF", "ANY", "OLD", "SHE", "HER", "ONE", "FIX", "FEW", "BUT", "WAS", "TOO", "OUT", "GET", "HAD", "SEE", "NOT", "MAP", "RUN", "FEV" },
                new string[] { "ONTO", "PLOT", "THAT", "WILL", "USED", "WITH", "SENT", "ABLE", "INTO", "WHEN", "HAVE", "LIFE", "GAME", "FIND", "FREE", "MUST", "STOP", "THEM", "DEEP", "CORE", "HELP", "CITY", "FROM", "BASE", "RACE", "LAST", "RULE", "ONLY", "JUST", "BEEN", "SHUT", "DOWN", "THEN", "WINS", "FOES", "GAIN", "OPEN", "VERY", "OVER", "COME", "WELL", "USES", "DRAG", "GOES", "LIKE", "PUSH", "BACK", "TELL", "SAFE", "MORE", "DAYS", "THIS", "TASK", "SOON", "KEEP", "TOOK", "COPY", "DONE", "MOST", "GETS", "KNOW", "TIME", "SEEM", "SOME", "LONG", "ALSO", "SETS", "AWAY", "EVEN", "MOVE", "THAN", "GUNS", "HOME", "WENT", "ENDS", "PART", "MAIN", "THEY", "SAVE", "GEAR", "WERE", "GIVE", "WIFE", "SORT", "EASY", "LEAD", "PASS", "UPON", "SLIP", "PAST", "SIDE", "WORK", "CAMP", "AREA", "TOWN", "HERE", "WHAT", "GONE", "PENS", "ONCE", "BEGS", "REST", "MAKE", "NOTE", "LEFT", "BUSY", "MANY", "DEAL", "BITS", "NEAR", "LOST", "TEAM", "MADE", "ALLY", "MUCH", "HATE", "KIND", "RAID", "ROCK", "GREW" },
                new string[] { "STORY", "BUILD", "KNOWN", "MINDS", "SCOUR", "ORDER", "POWER", "RULER", "SAVED", "START", "PLANS", "GROUP", "PARTS", "USING", "STEAD", "FOUND", "BRIEF", "AFTER", "BUILT", "CLOCK", "FAILS", "EARTH", "ENACT", "STARS", "VAULT", "ARMED", "OASIS", "NEARS", "VOICE", "WOMAN", "THEIR", "TELLS", "MONTH", "NEEDS", "KEEPS", "SPEND", "FIRST", "QUEST", "HELPS", "WHICH", "ELDER", "SINCE", "SEEMS", "BADLY", "GROWS", "WORLD", "QUIET", "FINDS", "HUMAN", "LATER", "LEARN", "THESE", "STAYS", "WAITS", "ASKED", "READY", "BEGIN", "GIVES", "SHOWS", "WHERE", "RUINS", "BRING", "FACES", "TAKEN", "THERE", "SIGNS", "PRODS", "LEADS", "HEALS", "ABOUT", "GOING", "STILL", "APTLY", "SKULL", "HEART", "SMALL", "TRICK", "THUGS", "COMES", "WATER", "ROUGH", "GOODS", "WHILE", "FREES", "SLAVE", "POINT", "FREED", "IDEAL", "PLACE", "HANDY", "STORE", "PICKS", "OTHER", "TRAIL", "PARTY", "BREAK", "MARKS", "SUPER", "NAMED", "VIRUS" },
                new string[] { "PLAYER", "ARMIES", "WASTES", "PIECES", "BECOME", "TOSSED", "MIDDLE", "KIDNAP", "KINDLY", "THWART", "SECRET", "HIDDEN", "OFFERS", "BEFORE", "FORGES", "FORCES", "NEEDED", "MINUTE", "LEARNS", "ATTACK", "PERIOD", "INSANE", "ACCESS", "AFRESH", "DESERT", "HUNGRY", "GEIGER", "UNABLE", "SLIDES", "GENTLY", "LEADER", "AROUND", "DEVICE", "CALLED", "MODULE", "LATELY", "STORES", "WANDER", "FILLED", "SPENDS", "GAINED", "POWERS", "DURING", "LONGER", "BRIDGE", "FIRMLY", "TRAVEL", "PIPBOY", "REMAIN", "FORMER", "SLIGHT", "RATHER", "NOBODY", "STOLEN", "BODIES", "SUDDEN", "PLEADS", "TRACKS", "FOLLOW", "LEAVES", "SLAVES", "ALWAYS", "RUMORS", "CENTER", "DEEPER", "COURSE", "PASSES", "POISED", "AMBUSH", "BATTLE", "COMBAT", "ADVICE", "CHANCE", "SHOULD", "ENLIST", "RETURN", "RECENT", "MUTANT", "EFFECT" },
                new string[] { "COMMAND", "ORBITAL", "WEAPONS", "COMPLEX", "ABILITY", "CONTROL", "BUILDER", "HARNESS", "AWESOME", "RAIDERS", "ENSLAVE", "ANDROID", "BENEATH", "BETWEEN", "MUTANTS", "AGAINST", "LEADING", "COHORTS", "DESTROY", "GATEWAY", "FALLOUT", "CARRIED", "ASSUMED", "LEAVING", "THIRSTY", "ARMORED", "HIMSELF", "COUNTER", "PACINKO", "MACHINE", "FARTHER", "VILLAGE", "PARTIES", "BROUGHT", "NULLMOD", "WORKING", "HEALING", "JOURNEY", "SEVERAL", "PSYCHIC", "WORRIED", "ATTACKS", "OUTSIDE", "HAZARDS", "MINIMAL", "BLAZING", "SUCCEED", "RETURNS", "WOUNDED", "VIOLENT", "MANAGED", "MONSTER", "OPTIONS", "DEALING", "ATTEMPT", "PROCESS", "SOMEONE", "LOCATED", "BECAUSE", "TRADING", "SLAVERS", "FREEDOM", "WELCOME", "REBUILD", "TALENTS", "CANTINA", "STRANGE", "FINDING", "FOLLOWS", "RAIDING", "SMALLER", "REALIZE", "ELEMENT", "HELPING", "ADVISES", "SLAVERY", "VARIETY", "UNUSUAL" },
                new string[] { "SYNOPSIS", "STUMBLES", "PLATFORM", "MONSTERS", "ABSOLUTE", "CONFLICT", "ENSLAVED", "UNCOVERS", "DISCOVER", "CITIZENS", "MAYVILLE", "CONTROLS", "COMPLETE", "UNLIKELY", "ALLIANCE", "ANDROIDS", "PRESSURE", "DICTATES", "ADVANCED", "RESERVES", "STRENGTH", "AWAKENED", "EXPLAINS", "FORAGING", "POSSIBLE", "SOFTWARE", "FACILITY", "RETRIEVE", "PROVIDES", "TRAINING", "COURTESY", "FRIENDLY", "STARTING", "EXPLORES", "DISTRUST", "VIOLENCE", "PEACEFUL", "ATTACKED", "PREDATOR", "ESCORTED", "MILITARY", "RESEARCH", "ARCHIVES", "VILLAGER", "SHACKLES", "GRATEFUL", "RETURNED", "DAUGHTER", "POWERFUL", "BUILDING", "ATTACHED", "MOUNTAIN", "PRESENCE", "FREQUENT", "HAPPENED", "SNEAKING", "PROMISES", "WEAPONRY", "AMBUSHED", "WITHDRAW", "SURPRISE", "DEFENDED", "HEGEMONY", "POSITION" },
                new string[] { "CHARACTER", "FORGOTTEN", "WASTELORD", "MESSIANIC", "DANGEROUS", "VILLAGERS", "STRUGGLES", "UNLOCKING", "SURVIVORS", "STERILIZE", "GENERATED", "AWAKENING", "WANDERING", "OUTSIDERS", "OPERATING", "EQUIPMENT", "BEGINNING", "SEPARATED", "HOLOCAUST", "ISOLATION", "HUMANKIND", "INSISTENT", "PREDATORS", "NECESSARY", "TOLERANCE", "PLUNDERED", "ENCOUNTER", "ATTACKERS", "DEATHCLAW", "BELIEVING", "MOUNTAINS", "REMAINING", "ARRANGING", "JAILBREAK", "BARTERING", "RETURNING", "OUTSKIRTS", "REARGUARD", "TRAVELERS", "IMPORTANT", "CERTAINLY", "SCIENTIST", "GRATITUDE", "QUESTIONS", "INITIALLY", "SUBJECTED", "INTELLECT" },
                new string[] { "HYPERLIGHT", "MYSTERIOUS", "TECHNOLOGY", "SCIENTISTS", "REVOLUTION", "VULNERABLE", "OBLITERATE", "UNEXPECTED", "IRRADIATED", "ADMIRATION", "ADDITIONAL", "MAINSTREAM", "RELATIVELY", "RESISTANCE", "ESPECIALLY", "CROSSROADS", "RECUPERATE", "EMPLOYMENT", "ACCEPTANCE", "ASSISTANCE", "DIRECTIONS" },
                new string[] { "TRANSMITTER", "DESTRUCTIVE", "CONTROLLING", "ERRATICALLY", "INFORMATION", "FREELOADERS", "UNDERGROUND", "DISMEMBERED" },
                new string[] { "PUPPETMASTER", "RECUPERATING", "INCREASINGLY", "THOUGHTFULLY" },
                new string[] { "TECHNOLOGICAL", "INVESTIGATING", "CONTEMPLATION", "PREOCCUPATION" }
            };

            // get the desired word length from the player
            Console.Write("Choose a word length: ");
            int wordLength = Convert.ToInt32(Console.ReadLine());

            // find the list of words where the words are the length the user chose
            string[] wordsWithCorrectLength = words[wordLength];

            // initialize a random number generator
            Random rng = new Random();

            // randomly choose 6 words from the list of words with that length. 
            // if there aren't 6 words with that length, just take all the words we have at that length. 
            string[] choices;
            if (wordsWithCorrectLength.Length > 6) {
                choices = new string[6];

                for (int index = 0; index < choices.Length; index++) {
                    // make sure we don't use the same word more than once.
                    bool foundWord = false;
                    while (!foundWord) {
                        string randomWord = wordsWithCorrectLength[rng.Next(wordsWithCorrectLength.Length)];
                        if (!ArrayContains(choices, randomWord)) {
                            choices[index] = randomWord;
                            foundWord = true;
                        }
                    }
                }
            } else {
                choices = wordsWithCorrectLength;
            }

            // choose a random word to be the correct word
            int randomIndex = rng.Next(choices.Length);
            string solutionWord = choices[randomIndex];

            // present player with options
            Console.WriteLine("Choose a word:");
            foreach (string word in choices) {
                Console.WriteLine(word);
            }
            Console.WriteLine("---");

            // convert solution word into a character array for easier comparison
            char[] solutionWordCharacters = solutionWord.ToCharArray();

            // play!
            bool gameOver = false;
            while (!gameOver) {
                // get player's guess
                string guess = Console.ReadLine();
                
                // make sure the user's choice is one of the options
                if (!ArrayContains(choices, guess)) {
                    Console.WriteLine("Your entry is not in the list.");
                } else {
                    // check if the user guessed correctly
                    if (guess == solutionWord) {
                        Console.WriteLine("Correct!");
                        gameOver = true;
                    } else {
                        char[] guessCharacters = guess.ToCharArray();

                        // calculate Likeness
                        int likeness = 0;
                        for (int charIndex = 0; charIndex < solutionWord.Length; charIndex++) {
                            if (solutionWordCharacters[charIndex] == guess[charIndex]) {
                                likeness++;
                            }
                        }

                        Console.WriteLine("Incorrect. Likeness: " + likeness);
                    }
                }
            }

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    

        private static bool ArrayContains(string[] choices, string randomWord)
        {
            for (int index = 0; index < choices.Length; index++) {
                if (choices[index] == randomWord) {
                    return true;
                }
            }
            return false;
        }
    }
}
