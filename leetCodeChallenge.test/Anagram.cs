using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace letmecodeChallenge.test
{
    public class Anagram
    {
        [Fact]
        public void e1()
        {
            string[] strs = new[] {"eat", "tea", "tan", "ate", "nat", "bat"};
            var result = GroupAnagrams(strs);

            IList<IList<string>> results = new List<IList<string>>
            {
                new List<string>() {"eat", "tea", "ate"},
                new List<string>() {"tan", "nat"},
                new List<string>() {"bat"},
            };

            Assert.Equal(results, result);
        }

        [Fact]
        public void e2()
        {
            string[] strs = new[] {"tea", "and", "ate", "eat", "dan"};
            var result = GroupAnagrams(strs);

            IList<IList<string>> results = new List<IList<string>>
            {
                new List<string>() {"tea", "ate", "eat"},
                new List<string>() {"and", "dan"}
            };

            Assert.Equal(results, result);
        }

        [Fact]
        public void e3()
        {
            string[] strs = new[]
            {
                "nozzle", "punjabi", "waterlogged", "imprison", "crux", "numismatists", "sultans", "rambles",
                "deprecating", "aware", "outfield", "marlborough", "guardrooms", "roast", "wattage", "shortcuts",
                "confidential", "reprint", "foxtrot", "dispossession", "floodgate", "unfriendliest", "semimonthlies",
                "dwellers", "walkways", "wastrels", "dippers", "engrossing", "undertakings", "unforeseen",
                "oscilloscopes", "pioneers", "geller", "neglects", "cultivates", "mantegna", "elicit", "couriered",
                "shielded", "shrew", "heartening", "lucks", "teammates", "jewishness", "documentaries", "subliming",
                "sultan", "redo", "recopy", "flippancy", "rothko", "conductor", "e", "carolingian", "outmanoeuvres",
                "gewgaw", "saki", "sarah", "snooping", "hakka", "highness", "mewling", "spender", "blockhead",
                "detonated", "cognac", "congaing", "prissy", "loathes", "bluebell", "involuntary", "aping", "sadly",
                "jiving", "buffalo", "chided", "instalment", "boon", "ashikaga", "enigmas", "recommenced", "snell",
                "parsley", "buns", "abracadabra", "forewomen", "persecuted", "carsick", "janitorial", "neonate",
                "expeditiously", "porterhouse", "bussed", "charm", "tinseled", "pencils", "inherits", "crew",
                "estimate", "blacktop", "mythologists", "essequibo", "dusky", "fends", "pithily", "positively",
                "participants", "brew", "tows", "pentathlon", "misdiagnoses", "paraphrase", "telephoning", "engining",
                "anglo", "duisburg", "shorthorns", "physical", "enquiries", "grudging", "floodlit", "safflower",
                "asphalts", "representing", "airbrush", "bedevilling", "fulminations", "peacefuller", "hurl",
                "unequalled", "wiser", "vinson", "paglia", "doggones", "optimist", "rulering", "katmandu", "flutists",
                "sterling", "oregonians", "boosts", "slaver", "straightedges", "stendhal", "defaulters", "stylize",
                "chucking", "adulterate", "partaking", "omelettes", "monochrome", "bitched", "foxhound", "tapir",
                "vocalizing", "manifolding", "northerner", "ineptly", "dunce", "matchbook", "locutions", "docudrama",
                "sinkers", "paralegal", "sip", "maliced", "lechers", "zippy", "tillman", "penknives", "olympias",
                "designates", "mossiest", "leanne", "lavishing", "understate", "underwriting", "showered", "belittle",
                "propounded", "gristly", "toxicity", "trike", "baudelaire", "sheers", "annmarie", "poultices",
                "therapeutics", "inputs", "bailed", "minutest", "pynchon", "jinx", "jackets", "subsections",
                "harmonizes", "caesareans", "freshened", "haring", "disruption", "buckle", "per", "pined", "solemnity",
                "recombined", "chamber", "tangling", "pitiful", "authoritarians", "oort", "ingratiate", "refreshed",
                "bavarian", "generically", "rescheduled", "typewritten", "level", "magnetism", "socialists",
                "oligocene", "resentful", "lambast", "counteroffer", "firefight", "phil", "attenuates", "teary",
                "demarcated", "moralities", "electrified", "pettiness", "unpacking", "hungary", "heavies", "tenancies",
                "tirade", "solaria", "scarcity", "prettiest", "carrillo", "yodel", "cantilever", "ridiculously",
                "tagalog", "schismatics", "ossification", "hezbollah", "downscaling", "calking", "tapped", "girl",
                "alba", "lavishness", "stepparents", "integrator", "overact", "father", "fobbing", "pb", "require",
                "toes", "sweats", "prisoners", "mbabane", "hatch", "motleyer", "worlds", "decentralize", "ingrained",
                "shekels", "directorship", "negotiating", "hiawatha", "busying", "reciprocate", "spinsterhood",
                "supervened", "scrimmage", "decolonized", "buildups", "sedative", "swats", "despotic", "driblets",
                "redoubting", "stoic", "xeroxes", "satellited", "exteriors", "deregulates", "lawful", "flunk",
                "broached", "energetics", "moodily", "popinjays", "shoshone", "misleads", "abduct", "nonevent", "flees",
                "harry", "cleverness", "manipulative", "shoplifts", "tom", "junk", "poniard", "transmute", "stricter",
                "trochees", "snack", "relations", "edger", "culminate", "implication", "carjacked", "kissers",
                "federate", "offsetting", "sutures", "wakened", "axis", "boxcars", "grinds", "scenting", "cordoba",
                "lumberyards", "incendiary", "antiphonal", "decipherable", "gilliam", "redecorates", "plum",
                "nitpickers", "linefeed", "awakes", "embittering", "spewing", "annul", "filial", "scarlet", "connors",
                "sanctum", "scotsman", "isobar", "activity", "overthrowing", "unseasoned", "tarantulae", "outtake",
                "diego", "mars", "stunted", "hunted", "sublimation", "barbadian", "barbarisms", "epidemic", "assesses",
                "imposture", "freaks", "detroit", "bloodiest", "avails", "prenatal", "connecticut", "guardsmen",
                "betwixt", "windsock", "neutralized", "psychoanalysis", "rubberized", "overproduces", "narcissism",
                "tallow", "cringes", "resinous", "paintbrushes", "duality", "paints", "deactivated", "expertly",
                "speedsters", "coward", "bass", "psychiatrist", "curies", "betrays", "bubble", "mellow", "showy",
                "retarding", "radishes", "coy", "unreservedly", "larks", "apportioned", "flaccid", "relabelling",
                "alphabeted", "anointment", "helms", "gillian", "trophying", "breakage", "underbrush", "directest",
                "wingtips", "pretence", "preshrink", "remarries", "addle", "brouhaha", "mobbing", "g", "dings", "gains",
                "stockade", "ouch", "particulates", "listens", "habituation", "kill", "crouped", "hyperbolae",
                "hutching", "stoney", "rightness", "davids", "questioned", "ethiopians", "courtliness", "delays",
                "navahos", "devils", "keeling", "accelerators", "investigator", "spindling", "illegality", "extremer",
                "revlon", "purity", "bradly", "jut", "machs", "liquidated", "informant", "smartly", "disfigure",
                "parliaments", "croup", "teletypes", "impression", "trainee", "implications", "embed", "podiatrists",
                "jewelled", "brokenhearted", "spaceman", "unsteadier", "kitchen", "twirling", "conurbations", "pygmies",
                "lourdes", "watertight", "reassessing", "dempsey", "matriarch", "alas", "abscissae", "decanter",
                "commentated", "sandy", "idler", "soybean", "cutoff", "dictate", "credibility", "indeterminable",
                "release", "blank", "curitiba", "pericardia", "probably", "indisposition", "hesitantly", "duff",
                "ratty", "derivative", "decals", "explication", "cockier", "monoxides", "hyperventilate", "genially",
                "polluter", "divan", "may", "convalesces", "morpheme", "pupa", "prospered", "tagging", "nerdier",
                "detached", "spearing", "hilbert", "russeted", "amanuensis", "periwinkles", "jujube", "guarantors",
                "premises", "descanting", "baned", "deviance", "sidearms", "lamentable", "barristers", "climes",
                "succulence", "mauve", "oceanographers", "migraine", "bisexual", "peruvians", "fatheads", "parsimony",
                "pilaf", "portly", "conniving", "insidiously", "inventing", "constabulary", "cling", "stunting",
                "accessioned", "deadliness", "overthrow", "expectorant", "agamemnon", "blindfold", "striker",
                "shrugging", "jibes", "appropriateness", "annihilates", "hairs", "proselytes", "goads", "rankling",
                "predominated", "hart", "enemies", "culpability", "drank", "martinets", "prospering", "dominick",
                "complemented", "invention", "foolscap", "tolerances", "lorelei", "profits", "awarer", "ungodlier",
                "victoriously", "mistrusts", "princes", "drudge", "moderator", "transversed", "disco", "japed",
                "loomed", "incense", "ponds", "gumbel", "disarranges", "coaxes", "technology", "hyde", "debentures",
                "confidantes", "hankered", "savant", "styes", "croupy", "unapproachable", "cisterns", "unto", "duds",
                "conglomerating", "clio", "negroid", "looked", "methodism", "hilario", "balloon", "thesauruses",
                "integuments", "thermometer", "slacks", "wigwagging", "gaping", "incensed", "misquotes", "chocking",
                "patrols", "upcoming", "insists", "livings", "thoth", "uselessness", "vibrated", "potluck", "starboard",
                "uniquer", "boone", "scintillates", "darker", "massey", "arbitrariness", "miniaturized", "rousseau",
                "chiffon", "consortia", "coral", "finesses", "half", "biked", "unlikeliest", "hilarious", "acrid",
                "twinkles", "galileo", "outsmarted", "ostentation", "cradle", "frats", "misidentifies", "uncleaner",
                "bacardi", "smoothest", "antwan", "warren", "jingling", "stocks", "daumier", "paranoid", "pantaloons",
                "dishing", "receive", "underpays", "kane", "variation", "beset", "disobliged", "dreadlocks", "psychics",
                "twofers", "lieutenants", "pebbling", "interposes", "shingles", "profanes", "machining", "dysfunctions",
                "wolfram", "brut", "nebraskan", "truculently", "copeland", "devonian", "fuller", "silvia",
                "philosophers", "cali", "adores", "disquiet", "savvies", "minatory", "blooms", "radiotelephones",
                "paradoxically", "competitions", "gandhi", "weddell", "occludes", "retracing", "kari", "dead",
                "lagoons", "menfolk", "abundant", "enacts", "conferences", "procreation", "steadier", "cols", "rabble",
                "unquestioned", "stupefying", "whodunit", "dizzier", "paula", "riposte", "elixirs", "discontented",
                "zimbabweans", "assemblage", "unsalted", "genders", "caldwell", "pulleys", "pureness", "kingston",
                "vests", "hearken", "abuses", "scull", "hussar", "solace", "gondwanaland", "surfacing", "vivienne",
                "subculture", "reciprocal", "expediencies", "projectiles", "segregationist", "prickle", "pooped",
                "telecommutes", "axes", "scenery", "peppery", "parenthesizing", "checked", "trademarked",
                "unreasonable", "curtly", "dynamically", "vulcanize", "airtight", "blotch", "edmund", "stoicism",
                "scrambles", "whirled", "chasing", "millstones", "helplessly", "permalloy", "remanding", "duplicate",
                "broadsided", "readjustment", "buggers", "quaked", "grapples", "democrats", "landfalls",
                "apprehensively", "turmoiling", "railing", "lothario", "modishly", "faggoted", "deflecting",
                "interment", "dodo", "recreants", "baywatch", "frescoes", "temblor", "brigade", "handgun", "bradstreet",
                "caspar", "godsend", "cochleae", "queered", "unevenness", "hairnet", "millimeters", "flawless",
                "plumbing", "disciplinarian", "orbiting", "foothill", "serviettes", "peseta", "windmills", "myrdal",
                "provides", "slowdowns", "clouting", "gainsays", "dishpans", "mediates", "weaker", "shoestrings",
                "gerunds", "potsdam", "chips", "disqualifications", "focus", "quarry", "dwarfs", "laurels", "coverall",
                "reconsidered", "exploded", "distending", "bronzes", "apollonian", "sweeper", "couperin", "gourmets",
                "irreconcilable", "goldbricking", "emotes", "demilitarizes", "lambkin", "grouper", "anyways", "hugs",
                "quizzed", "misstatement", "spectrums", "frigates", "plenipotentiaries", "parasites", "tacitly",
                "savvying", "treks", "dissociating", "departing", "resins", "psychiatric", "tablespoonfuls", "aught",
                "makeup", "copping", "interwove", "selling", "fantasize", "flamingos", "smolders", "stript", "laverne",
                "extremely", "chattering", "imminent", "vaulting", "slackly", "pasteurizes", "goody", "pearls",
                "conceptualization", "fins", "brogues", "muskogee", "naziism", "stromboli", "sunflower", "tosca",
                "luridness", "booing", "zaniness", "creel", "bootblacks", "attendants", "swordplay", "impinging",
                "premiere", "sedimentation", "traffickers", "carrel", "observatories", "telltales", "cuckolded",
                "ampler", "alternately", "shovel", "tasmania", "whooping", "methodologies", "pickling", "overseer",
                "incentive", "countersink", "pickaxing", "explicit", "unethical", "seoul", "gyrates", "dismounting",
                "dartboard", "socialism", "sissiest", "radiotherapist", "sprawl", "hems", "raggedier", "conscripted",
                "repealed", "implanted", "coverage", "traitorous", "barmaid", "pointier", "huntress", "summers",
                "finnish", "mouthed", "mamore", "lemur", "osteoporosis", "frowziest", "sop", "comical", "speedup",
                "oasis", "peon", "testers", "stances", "chuckles", "childes", "consensuses", "rastafarian",
                "battlement", "christies", "urbanized", "penitence", "replenishment", "disperse", "kibosh",
                "combatting", "repealing", "guise", "grassiest", "grafts", "waddle", "pigsties", "moneymaking",
                "polite", "reprogramming", "audaciously", "gorier", "blaze", "yaqui", "racially", "inc",
                "reupholstering", "fez", "lemaitre", "nineties", "pedal", "deferred", "tranquil", "surveyor", "narrow",
                "hopper", "solemnize", "federate", "trisecting", "cravat", "lille", "biography", "land", "jazzing",
                "rhomboids", "nudes", "mundanely", "greenbacks", "chattel", "deceleration", "devoting", "itemizing",
                "routing", "jukebox", "passkey", "infants", "prerecorded", "fuzzing", "gandhi", "roseate", "bandit",
                "prong", "bowels", "bounciest", "misdeeds", "unseemliness", "emceed", "later", "hailed", "crotchet",
                "steepness", "jot", "improves", "eucharistic", "natalia", "exalt", "performers", "predictor",
                "voyeurism", "fedex", "activate", "crypt", "magics", "treats", "viewed", "chauffeur", "ladybug",
                "peppiest", "seismic", "microscopes", "liners", "wraps", "footman", "tape", "daubers", "aerial",
                "sparer", "politic", "shamed", "decal", "ayrshire", "ruggeder", "washcloths", "neurologists",
                "singsong", "kaitlin", "conn", "monopolizes", "sunroof", "zonked", "overall", "celsius", "fins",
                "caparison", "imus", "enfranchises", "microns", "promulgates", "aspartame", "fails", "decamps",
                "spiciness", "impieties", "starring", "receded", "skying", "suetonius", "pornographers",
                "intellectualized", "truckled", "abdications", "openness", "principally", "sellers", "complaining",
                "jeopardizing", "concerto", "fibula", "cliffs", "aorta", "inhale", "transgressions", "copywriter",
                "understands", "coccis", "disperses", "fraying", "strengths", "macaulay", "mitigation", "competences",
                "ides", "linked", "tawnier", "hallucinate", "dairymen", "puffier", "matchless", "wheeling", "drily",
                "nephews", "clandestinely", "tsingtao", "disarraying", "headier", "experts", "yippee", "repellent",
                "tributary", "clannish", "dumpsters", "genealogies", "ballooned", "denouements", "hymned", "length",
                "sasses", "uncontrollably", "fortune", "wastefully", "overproducing", "sickening", "headboard", "burrs",
                "prohibits", "keogh", "outs", "lamer", "repressed", "rowdyism", "transgressed", "euros", "amenity",
                "garfunkel", "rather", "noseys", "lampoons", "raja", "impermanence", "heaters", "shakespeareans",
                "judiciaries", "tweaked", "extrapolations", "succeeded", "jowls", "vociferation", "roadways", "herb",
                "inactivity", "registrars", "checks", "deservedly", "heehaws", "apologetics", "fatness", "aced",
                "promote", "atriums", "deidre", "redound", "litterbug", "barehanded", "scheduled", "flakiest",
                "twirler", "graduated", "coccus", "gadfly", "unforeseeable", "emendation", "woodsman", "wiriest",
                "tangelo", "weakening", "intimidating", "sternness", "reiteration", "wicca", "heresies", "inches",
                "encodes", "sidebar", "starking", "wastelands", "pepsi", "emigrate", "stuttgart", "shindigs", "pansy",
                "chintzy", "limbo", "disbarred", "gallivant", "hallmarked", "respiratory", "eminences", "unabated",
                "affirms", "twinned", "wordiness", "installing", "donn", "westerly", "interfaces", "benton", "mussy",
                "identical", "sulfates", "starvings", "woodwork", "hyphenated", "catechizing", "transition",
                "dramatist", "demilitarize", "buber", "spoonful", "laconic", "undervaluing", "inestimably", "severer",
                "improvidence", "stoneware", "cholera", "peru", "rearm", "recluses", "diaz", "tablespoonsful",
                "sandals", "cinderella", "insubordination", "sires", "stern", "jeremiah", "snowbound", "ramifies",
                "lexicographer", "skimpiest", "predetermining", "lapidary", "dentists", "upbeats", "marketplace",
                "ploughs", "esteem", "miserably", "overreaction", "unlikelihood", "kinswoman", "averts",
                "remonstrating", "asinine", "amortize", "wasps", "coal", "tenderfoot", "subplot", "coyotes",
                "sauntering", "rices", "fraughts", "decoded", "millipedes", "knocking", "homework", "furor",
                "expansionists", "j", "emergency", "sharon", "provisoes", "president", "assuaging", "curtail",
                "indigestion", "liming", "cryptozoic", "auguring", "indenture", "magisterially", "groped", "ensue",
                "steaming", "mutinous", "incomplete", "yuletide", "nomenclatures", "hundredth", "jimmies", "irk",
                "common", "wetly", "volley", "summary", "obsequies", "granola", "forests", "allege", "informal",
                "shapeless", "earplugs", "disunite", "insinuations", "junked", "riverbeds", "georgian", "brushed",
                "sequenced", "bucketfuls", "spiel", "humors", "screwed", "capitulating", "downturns", "intimidates",
                "refueling", "mingled", "arisen", "dragnet", "aftereffects", "practised", "obduracy", "canon",
                "penning", "inflammatory", "wisher", "actuate", "kari", "actuating", "reupholstered", "successes",
                "inborn", "canvasbacks", "incapacitated", "aristocratic", "britt", "lazying", "hymnals", "tyroes",
                "tamper", "graduate", "franc", "seasons", "pompom", "throeing", "deviate", "leveling", "inaccurate",
                "impaling", "trouping", "restoring", "deduces", "perforating", "artie", "alleghenies", "crusader",
                "rosemary", "chastest", "educational", "caveatting", "ablest", "doorstepped", "strange",
                "eccentricities", "sublimity", "afire", "humbugging", "jots", "ordinary", "foyer", "kayak", "snake",
                "wheal", "dispensations", "transponders", "zing", "pit", "meowing", "improved", "crowd", "nonfatal",
                "epsilon", "nodding", "cyclones", "imbibed", "rebroadcasting", "quibbles", "moisturizes", "zippy",
                "braille", "visaing", "abetters", "lurked", "snafus", "moppet", "lemon", "wifeliest", "stuarts",
                "boyish", "reapportion", "kneecaps", "stymying", "villagers", "obscenity", "bumble", "zeroing",
                "objectionably", "connolly", "memorial", "clanging", "gallstones", "dibbled", "outlasting", "mendez",
                "reproaching", "antagonized", "sisterhoods", "hunchbacks", "superimposed", "siphon", "professionally",
                "spermicides", "lebanon", "facing", "pierces", "philosophically", "mcdowell", "rotated", "tic",
                "correspondents", "nonplussed", "litchi", "ascots", "millennial", "booked", "immunize", "prefabricate",
                "spumoni", "odyssey", "fey", "bunched", "olen", "regularizing", "superconductors", "aside", "infirmary",
                "allaying", "saturdays", "caucasian", "doreen", "france", "speeding", "wretched", "slovakia",
                "chiselled", "peseta", "tho", "gales", "loincloths", "shock", "readers", "boarder", "entryway",
                "toning", "transitively", "preponderances", "internships", "rating", "pelleting", "audition",
                "amusement", "theed", "cocked", "toddler", "rusty", "kinfolk", "frames", "gorgonzola", "overrate",
                "lightweight", "bayous", "populists", "insensible", "bandoliers", "travelogs", "tactically",
                "weatherproofs", "sleigh", "develops", "oxygenate", "relaid", "mimi", "wheezier", "chill", "salween",
                "theatre", "vitalizes", "nun", "olives", "offings", "tricycling", "tipper", "kindly", "bellies",
                "sixteenths", "ganglia", "recombining", "eastward", "minestrone", "fairgrounds", "undelivered",
                "scapula", "breadth", "groupie", "ophelia", "adrenaline", "dork", "autographing", "watersides", "sent",
                "socks", "somnolence", "systematize", "signings", "rachmaninoff", "santa", "snacks", "leno", "spurs",
                "heliotropes", "silenced", "roundhouses", "illegitimacy", "hedgehog", "wet", "depressed", "eris",
                "pure", "pouncing", "obtuseness", "caulk", "openly", "kerosene", "grille", "buccaneers", "oar",
                "modals", "playacts", "shroud", "plowshares", "iciness", "retort", "jaunt", "identities", "mellower",
                "redesigning", "molest", "forlorner", "guacamole", "cohan", "refocus", "dossier", "interrogating",
                "cants", "diligence", "stomps", "enjoy", "awe", "loggerhead", "csonka", "inversions", "den", "lunged",
                "alkaid", "palming", "delivers", "proprietorship", "groveler", "choreographs", "instals", "merton",
                "cyclops", "augmentation", "manipulated", "nasal", "trousseaux", "critiques", "arenas", "stale",
                "suspect", "behoove", "propose", "cellulite", "purification", "leah", "polestar", "potato", "gladlier",
                "sunders", "entreat", "herbalist", "filthier", "skinflints", "asseverating", "insulted", "mildly",
                "modulate", "charges", "libyans", "weekended", "rodeos", "allegedly", "tarawa", "valedictorians",
                "spacy", "spontaneously", "yore", "classify", "centigrade", "videoing", "airdropping", "dejection",
                "pierce", "imagined", "isabel", "reiterates", "blazing", "stuck", "deceasing", "netherlands", "citric",
                "tormented", "monotoning", "bestowals", "betrayals", "adoptions", "scrolls", "sex", "idol", "whaler",
                "telephotos", "conjugation", "abductions", "bundestag", "disruptions", "nouakchott", "stuffiest",
                "goodly", "dissatisfying", "anglicize", "flowing", "identifying", "depots", "stoicism", "thessalonian",
                "hundred", "whetstone", "defroster", "headwaiter", "feisty", "inhibited", "reamed", "demonstrator",
                "accursed", "hector", "interchanges", "erotically", "sportscaster", "gentlewomen", "teabag", "smelts",
                "disorganization", "conveniently", "maugham", "hatchery", "regards", "arguably", "govern", "boulevards",
                "niches", "gristlier", "obtrude", "catharses", "throughway", "stoppered", "drinkers", "indeterminacy",
                "vacuums", "plainest", "acuff", "eases", "defined", "splurge", "severing", "griddles", "thermoplastics",
                "dilution", "vinegary", "straights", "testament", "sticks", "shanghai", "childproofing", "clobbers",
                "taco", "castro", "arrests", "fetter", "discomposing", "timbres", "wondrous", "pullmans", "amusements",
                "telephonic", "manning", "inhabiting", "finery", "admires", "defensively", "fiord", "incriminate",
                "oust", "collapse", "deliquescent", "bulwark", "consciousness", "roguery", "beefburger", "amounted",
                "pheasants", "archdioceses", "vote", "gujarati", "forwards", "waggling", "tanned", "liberalization",
                "chap", "finishing", "catawba", "anus", "farina", "butterflying", "folks", "crumple", "criticize",
                "unswerving", "snack", "gentrification", "enthroning", "drearies", "marietta", "farley", "recede",
                "incise", "electrodes", "dirac", "corn", "livest", "coughs", "noreen", "rapscallion", "codeine",
                "acidly", "confiscates", "dislikes", "administrators", "valid", "prep", "legated", "wherewithal",
                "subjugating", "wallabies", "boning", "creakiest", "erotica", "neophytes", "drowses", "bushmen",
                "basis", "regattas", "melancholy", "clubfeet", "there", "generalized", "rotunding", "condone",
                "hemlines", "bantered", "vertebral", "ruby", "companions", "postmarked", "aping", "finalized", "prado",
                "mutilations", "partied", "isiah", "desk", "calcines", "agreeing", "bode", "cygnet", "downsizing",
                "naiads", "preambled", "recife", "randall", "gillespie", "convalescent", "victories", "obsessed",
                "leaders", "strips", "parmesan", "germicide", "clarion", "pictograph", "nutshells", "bungalows",
                "hagged", "colosseum", "ferraro", "recapitulations", "labored", "acrostic", "dynamics", "bucked",
                "betaking", "pragmatically", "gobbed", "glossy", "congresses", "rewindable", "trout", "renovates",
                "mattered", "davenport", "stenographer", "nudism", "deduced", "unattributed", "equally", "wrestled",
                "sequoia", "measurable", "lamb", "babe", "concourses", "creamer", "fascination", "steroids", "deplaned",
                "germinated", "progressed", "swashbuckling", "pools", "officemax", "brewers", "banjul", "thong",
                "periodic", "grub", "typescript", "lemurs", "excreta", "seeps", "clearinghouses", "isolating",
                "particularized", "thallium", "waistcoat", "misread", "extensiveness", "violations", "insistent",
                "zany", "newses", "predominate", "enunciating", "ultras", "burlap", "dowelled", "elision", "person",
                "minneapolis", "edification", "endued", "asseverates", "meeter", "iceberg", "mexican", "end", "wale",
                "veronese", "ida", "earshot", "tunnels", "debuting"
            };
            var result = GroupAnagrams(strs);

            IList<IList<string>> results = new List<IList<string>>
            {
                new List<string>() {"tea", "ate", "eat"},
                new List<string>() {"and", "dan"}
            };

            Assert.True( result.Count > 0);
        }

        [Fact]
        public void e6()
        {
            string[] strs = new[]
            {
                "incentive", "countersink", "pickaxing", "explicit", "unethical", "seoul", "gyrates", "dismounting",
                "dartboard", "socialism", "sissiest", "radiotherapist", "sprawl", "hems", "raggedier", "conscripted",
                "repealed", "implanted", "coverage", "traitorous", "barmaid", "pointier", "huntress", "summers",
                "finnish", "mouthed", "mamore", "lemur", "osteoporosis", "frowziest", "sop", "comical", "speedup",
                "oasis", "peon", "testers", "stances", "chuckles", "childes", "consensuses", "rastafarian",
                "battlement", "christies", "urbanized", "penitence", "replenishment", "disperse", "kibosh",
                "combatting", "repealing", "guise", "grassiest", "grafts", "waddle", "pigsties", "moneymaking",
                "polite", "reprogramming", "audaciously", "gorier", "blaze", "yaqui", "racially", "inc",
                "reupholstering", "fez", "lemaitre", "nineties", "pedal", "deferred", "tranquil", "surveyor", "narrow",
                "hopper", "solemnize", "federate", "trisecting", "cravat", "lille", "biography", "land", "jazzing",
                "rhomboids", "nudes", "mundanely", "greenbacks", "chattel", "deceleration", "devoting", "itemizing",
                "routing", "jukebox", "passkey", "infants", "prerecorded", "fuzzing", "gandhi", "roseate", "bandit",
                "prong", "bowels", "bounciest", "misdeeds", "unseemliness", "emceed", "later", "hailed", "crotchet",
                "steepness", "jot", "improves", "eucharistic", "natalia", "exalt", "performers", "predictor",
                "voyeurism", "fedex", "activate", "crypt", "magics", "treats", "viewed", "chauffeur", "ladybug",
                "peppiest", "seismic", "microscopes", "liners", "wraps", "footman", "tape", "daubers", "aerial",
                "sparer", "politic", "shamed", "decal", "ayrshire", "ruggeder", "washcloths", "neurologists",
                "singsong", "kaitlin", "conn", "monopolizes", "sunroof", "zonked", "overall", "celsius", "fins",
                "caparison", "imus", "enfranchises", "microns", "promulgates", "aspartame", "fails", "decamps",
                "spiciness", "impieties", "starring", "receded", "skying", "suetonius", "pornographers",
                "intellectualized", "truckled", "abdications", "openness", "principally", "sellers", "complaining",
                "jeopardizing", "concerto", "fibula", "cliffs", "aorta", "inhale", "transgressions", "copywriter",
                "understands", "coccis", "disperses", "fraying", "strengths", "macaulay", "mitigation", "competences",
                "ides", "linked", "tawnier", "hallucinate", "dairymen", "puffier", "matchless", "wheeling", "drily",
                "nephews", "clandestinely", "tsingtao", "disarraying", "headier", "experts", "yippee", "repellent",
                "tributary", "clannish", "dumpsters", "genealogies", "ballooned", "denouements", "hymned", "length",
                "sasses", "uncontrollably", "fortune", "wastefully", "overproducing", "sickening", "headboard", "burrs",
                "prohibits", "keogh", "outs", "lamer", "repressed", "rowdyism", "transgressed", "euros", "amenity",
                "garfunkel", "rather", "noseys", "lampoons", "raja", "impermanence", "heaters", "shakespeareans",
                "judiciaries", "tweaked", "extrapolations", "succeeded", "jowls", "vociferation", "roadways", "herb",
                "inactivity", "registrars", "checks", "deservedly", "heehaws", "apologetics", "fatness", "aced",
                "promote", "atriums", "deidre", "redound", "litterbug", "barehanded", "scheduled", "flakiest",
                "twirler", "graduated", "coccus", "gadfly", "unforeseeable", "emendation", "woodsman", "wiriest",
                "tangelo", "weakening", "intimidating", "sternness", "reiteration", "wicca", "heresies", "inches",
                "encodes", "sidebar", "starking", "wastelands", "pepsi", "emigrate", "stuttgart", "shindigs", "pansy",
                "chintzy", "limbo", "disbarred", "gallivant", "hallmarked", "respiratory", "eminences", "unabated",
                "affirms", "twinned", "wordiness", "installing", "donn", "westerly", "interfaces", "benton", "mussy",
                "identical", "sulfates", "starvings", "woodwork", "hyphenated", "catechizing", "transition",
                "dramatist", "demilitarize", "buber", "spoonful", "laconic", "undervaluing", "inestimably", "severer",
                "improvidence", "stoneware", "cholera", "peru", "rearm", "recluses", "diaz", "tablespoonsful",
                "sandals", "cinderella", "insubordination", "sires", "stern", "jeremiah", "snowbound", "ramifies",
                "lexicographer", "skimpiest", "predetermining", "lapidary", "dentists", "upbeats", "marketplace",
                "ploughs", "esteem", "miserably", "overreaction", "unlikelihood", "kinswoman", "averts",
                "remonstrating", "asinine", "amortize", "wasps", "coal", "tenderfoot", "subplot", "coyotes",
                "sauntering", "rices", "fraughts", "decoded", "millipedes", "knocking", "homework", "furor",
                "expansionists", "j", "emergency", "sharon", "provisoes", "president", "assuaging", "curtail",
                "indigestion", "liming", "cryptozoic", "auguring", "indenture", "magisterially", "groped", "ensue",
                "steaming", "mutinous", "incomplete", "yuletide", "nomenclatures", "hundredth", "jimmies", "irk",
                "common", "wetly", "volley", "summary", "obsequies", "granola", "forests", "allege", "informal",
                "shapeless", "earplugs", "disunite", "insinuations", "junked", "riverbeds", "georgian", "brushed",
                "sequenced", "bucketfuls", "spiel", "humors", "screwed", "capitulating", "downturns", "intimidates",
                "refueling", "mingled", "arisen", "dragnet", "aftereffects", "practised", "obduracy", "canon",
                "penning", "inflammatory", "wisher", "actuate", "kari", "actuating", "reupholstered", "successes",
                "inborn", "canvasbacks", "incapacitated", "aristocratic", "britt", "lazying", "hymnals", "tyroes",
                "tamper", "graduate", "franc", "seasons", "pompom", "throeing", "deviate", "leveling", "inaccurate",
                "impaling", "trouping", "restoring", "deduces", "perforating", "artie", "alleghenies", "crusader",
                "rosemary", "chastest", "educational", "caveatting", "ablest", "doorstepped", "strange",
                "eccentricities", "sublimity", "afire", "humbugging", "jots", "ordinary", "foyer", "kayak", "snake",
                "wheal", "dispensations", "transponders", "zing", "pit", "meowing", "improved", "crowd", "nonfatal",
                "epsilon", "nodding", "cyclones", "imbibed", "rebroadcasting", "quibbles", "moisturizes", "zippy",
                "braille", "visaing", "abetters", "lurked", "snafus", "moppet", "lemon", "wifeliest", "stuarts",
                "boyish", "reapportion", "kneecaps", "stymying", "villagers", "obscenity", "bumble", "zeroing",
                "objectionably", "connolly", "memorial", "clanging", "gallstones", "dibbled", "outlasting", "mendez",
                "reproaching", "antagonized", "sisterhoods", "hunchbacks", "superimposed", "siphon", "professionally",
                "spermicides", "lebanon", "facing", "pierces", "philosophically", "mcdowell", "rotated", "tic",
                "correspondents", "nonplussed", "litchi", "ascots", "millennial", "booked", "immunize", "prefabricate",
                "spumoni", "odyssey", "fey", "bunched", "olen", "regularizing", "superconductors", "aside", "infirmary",
                "allaying", "saturdays", "caucasian", "doreen", "france", "speeding", "wretched", "slovakia",
                "chiselled", "peseta", "tho", "gales", "loincloths", "shock", "readers", "boarder", "entryway",
                "toning", "transitively", "preponderances", "internships", "rating", "pelleting", "audition",
                "amusement", "theed", "cocked", "toddler", "rusty", "kinfolk", "frames", "gorgonzola", "overrate",
                "lightweight", "bayous", "populists", "insensible", "bandoliers", "travelogs", "tactically",
                "weatherproofs", "sleigh", "develops", "oxygenate", "relaid", "mimi", "wheezier", "chill", "salween",
                "theatre", "vitalizes", "nun", "olives", "offings", "tricycling", "tipper", "kindly", "bellies",
                "sixteenths", "ganglia", "recombining", "eastward", "minestrone", "fairgrounds", "undelivered",
                "scapula", "breadth", "groupie", "ophelia", "adrenaline", "dork", "autographing", "watersides", "sent",
                "socks", "somnolence", "systematize", "signings", "rachmaninoff", "santa", "snacks", "leno", "spurs",
                "heliotropes", "silenced", "roundhouses", "illegitimacy", "hedgehog", "wet", "depressed", "eris",
                "pure", "pouncing", "obtuseness", "caulk", "openly", "kerosene", "grille", "buccaneers", "oar",
                "modals", "playacts", "shroud", "plowshares", "iciness", "retort", "jaunt", "identities", "mellower",
                "redesigning", "molest", "forlorner", "guacamole", "cohan", "refocus", "dossier", "interrogating",
                "cants", "diligence", "stomps", "enjoy", "awe", "loggerhead", "csonka", "inversions", "den", "lunged",
                "alkaid", "palming", "delivers", "proprietorship", "groveler", "choreographs", "instals", "merton",
                "cyclops", "augmentation", "manipulated", "nasal", "trousseaux", "critiques", "arenas", "stale",
                "suspect", "behoove", "propose", "cellulite", "purification", "leah", "polestar", "potato", "gladlier",
                "sunders", "entreat", "herbalist", "filthier", "skinflints", "asseverating", "insulted", "mildly",
                "modulate", "charges", "libyans", "weekended", "rodeos", "allegedly", "tarawa", "valedictorians",
                "spacy", "spontaneously", "yore", "classify", "centigrade", "videoing", "airdropping", "dejection",
                "pierce", "imagined", "isabel", "reiterates", "blazing", "stuck", "deceasing", "netherlands", "citric",
                "tormented", "monotoning", "bestowals", "betrayals", "adoptions", "scrolls", "sex", "idol", "whaler",
                "telephotos", "conjugation", "abductions", "bundestag", "disruptions", "nouakchott", "stuffiest",
                "goodly", "dissatisfying", "anglicize", "flowing", "identifying", "depots", "stoicism", "thessalonian",
                "hundred", "whetstone", "defroster", "headwaiter", "feisty", "inhibited", "reamed", "demonstrator",
                "accursed", "hector", "interchanges", "erotically", "sportscaster", "gentlewomen", "teabag", "smelts",
                "disorganization", "conveniently", "maugham", "hatchery", "regards", "arguably", "govern", "boulevards",
                "niches", "gristlier", "obtrude", "catharses", "throughway", "stoppered", "drinkers", "indeterminacy",
                "vacuums", "plainest", "acuff", "eases", "defined", "splurge", "severing", "griddles", "thermoplastics",
                "dilution", "vinegary", "straights", "testament", "sticks", "shanghai", "childproofing", "clobbers",
                "taco", "castro", "arrests", "fetter", "discomposing", "timbres", "wondrous", "pullmans", "amusements",
                "telephonic", "manning", "inhabiting", "finery", "admires", "defensively", "fiord", "incriminate",
                "oust", "collapse", "deliquescent", "bulwark", "consciousness", "roguery", "beefburger", "amounted",
                "pheasants", "archdioceses", "vote", "gujarati", "forwards", "waggling", "tanned", "liberalization",
                "chap", "finishing", "catawba", "anus", "farina", "butterflying", "folks", "crumple", "criticize",
                "unswerving", "snack", "gentrification", "enthroning", "drearies", "marietta", "farley", "recede",
                "incise", "electrodes", "dirac", "corn", "livest", "coughs", "noreen", "rapscallion", "codeine",
                "acidly", "confiscates", "dislikes", "administrators", "valid", "prep", "legated", "wherewithal",
                "subjugating", "wallabies", "boning", "creakiest", "erotica", "neophytes", "drowses", "bushmen",
                "basis", "regattas", "melancholy", "clubfeet", "there", "generalized", "rotunding", "condone",
                "hemlines", "bantered", "vertebral", "ruby", "companions", "postmarked", "aping", "finalized", "prado",
                "mutilations", "partied", "isiah", "desk", "calcines", "agreeing", "bode", "cygnet", "downsizing",
                "naiads", "preambled", "recife", "randall", "gillespie", "convalescent", "victories", "obsessed",
                "leaders", "strips", "parmesan", "germicide", "clarion", "pictograph", "nutshells", "bungalows",
                "hagged", "colosseum", "ferraro", "recapitulations", "labored", "acrostic", "dynamics", "bucked",
                "betaking", "pragmatically", "gobbed", "glossy", "congresses", "rewindable", "trout", "renovates",
                "mattered", "davenport", "stenographer", "nudism", "deduced", "unattributed", "equally", "wrestled",
                "sequoia", "measurable", "lamb", "babe", "concourses", "creamer", "fascination", "steroids", "deplaned",
                "germinated", "progressed", "swashbuckling", "pools", "officemax", "brewers", "banjul", "thong",
                "periodic", "grub", "typescript", "lemurs", "excreta", "seeps", "clearinghouses", "isolating",
                "particularized", "thallium", "waistcoat", "misread", "extensiveness", "violations", "insistent",
                "zany", "newses", "predominate", "enunciating", "ultras", "burlap", "dowelled", "elision", "person",
                "minneapolis", "edification", "endued", "asseverates", "meeter", "iceberg", "mexican", "end", "wale",
                "veronese", "ida", "earshot", "tunnels", "debuting"
            };
            var result = GroupAnagrams(strs);

            IList<IList<string>> results = new List<IList<string>>
            {
                new List<string>() {"ate", "eat", "tea"},
                new List<string>() {"nat", "tan"},
                new List<string>() {"bat"},
            };
//
//            Assert.Equal(results, result);
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> groupAnagrams = new List<IList<string>>();
            List<WordComp> residue;
            var strsSorted = strs.Select(s => new WordComp {word = s, sort = SortString(s)}).ToList();

            while (strsSorted.Count > 0)
            {
                residue = new List<WordComp>();
                var anagrams = new List<WordComp>();

                WordComp wordToCompare = new WordComp();
                foreach (var word in strsSorted)
                {
                    if (anagrams.Count == 0)
                    {
                        anagrams.Add(word);
                        wordToCompare = word;
                    }
                    else
                    {
                        if (wordToCompare.word == word.word || wordToCompare.sort == word.sort)
                        {
                            anagrams.Add(word);
                        }
                        else
                        {
                            residue.Add(word);
                        }
                    }
                }

                groupAnagrams.Add(anagrams.Select(a => a.word).ToList());
                strsSorted = residue;
            }

            return groupAnagrams;
        }

        private static string SortString(string s)
        {
            var concat = String.Concat(s.OrderBy(a => a));
            return concat;
        }
    }

    public class WordComp
    {
        public string word { get; set; }
        public string sort { get; set; }
    }
}
