using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GameShop.Models;

namespace GameShop.Data
{
    public static class SampleData
    {
        public static void Initialize(GameContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                new Category
                {
                    Name = "Action",
                    NameUA = "Екшн",
                    NameDE = "Aktion"
                },
                new Category
                {
                    Name = "Adventure",
                    NameUA = "Пригоди",
                    NameDE = "Abenteuer"
                },
                new Category
                {
                    Name = "Casual",
                    NameUA = "Казуальні",
                    NameDE = "Lässig"
                },
                new Category
                {
                    Name = "Co-op",
                    NameUA = "Кооперативні",
                    NameDE = "Kooperative"
                },
                new Category
                {
                    Name = "Fighting",
                    NameUA = "Бійки",
                    NameDE = "Kampf"
                },
                new Category
                {
                    Name = "Open World",
                    NameUA = "Відкритий світ",
                    NameDE = "Offene Welt"
                },
                new Category
                {
                    Name = "RPG",
                    NameUA = "Рольові",
                    NameDE = "Rollenspiel"
                },
                new Category
                {
                    Name = "Simulation",
                    NameUA = "Симуляції",
                    NameDE = "Simulation"
                },
                new Category
                {
                    Name = "Strategy",
                    NameUA = "Стратегії",
                    NameDE = "Strategie"
                }
                );
                context.SaveChanges();
            }
            if (!context.Games.Any())
            {
                context.Games.AddRange(
                    new Game
                    {
                        Title = "Among Us",
                        Description = "Play with 4-15 players online or via local WiFi as you attempt to prepare your spaceship for departure, but beware as one or more random players among the Crew are Impostors bent on killing everyone!",
                        DescriptionDE = "Spielen Sie mit 4-15 Spielern online oder über lokales WLAN, während Sie versuchen, Ihr Raumschiff für den Abflug vorzubereiten, aber seien Sie vorsichtig, da einer oder mehrere zufällige Spieler in der Crew Betrüger sind, die darauf aus sind, alle zu töten!",
                        DescriptionUA = "Грайте з 4-15 гравцями онлайн або через локальний Wi-Fi, намагаючись підготувати свій космічний корабель до вильоту, але будьте обережні, оскільки один або кілька випадкових гравців серед екіпажу є самозванцями, які прагнуть вбити всіх!",
                        ImageLink = "https://cdn1.epicgames.com/salesEvent/salesEvent/amogusportrait_1200x1600-66ad0e4d363e1c92f9f8aae67a96dd31?h=854&resize=1&w=640",
                        Price = 69,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Casual"),
                            context.Categories.First(c => c.Name == "Co-op"),
                        }
                    },
                    new Game
                    {
                        Title = "Grand Theft Auto V",
                        Description = "When a young street hustler, a retired bank robber and a terrifying psychopath land themselves in trouble, they must pull off a series of dangerous heists to survive in a city in which they can trust nobody, least of all each other.",
                        DescriptionDE = "Als ein junger Straßendiener, ein Bankräuber im Ruhestand und ein furchterregender Psychopath in Schwierigkeiten geraten, müssen sie eine Reihe gefährlicher Raubüberfälle durchführen, um in einer Stadt zu überleben, in der sie niemandem vertrauen können, am allerwenigsten einander.",
                        DescriptionUA = "Коли молодий вуличний торговець, грабіжник банку на пенсії і жахливий психопат потрапляють у біду, вони повинні здійснити серію небезпечних пограбувань, щоб вижити в місті, в якому вони нікому не можуть довіряти, а тим більше один одному.",
                        ImageLink = "https://cdn1.epicgames.com/0584d2013f0149a791e7b9bad0eec102/offer/GTAV_EGS_Artwork_1200x1600_Portrait%20Store%20Banner-1200x1600-382243057711adf80322ed2aeea42191.jpg?h=854&resize=1&w=640",
                        Price = 629,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Action"),
                            context.Categories.First(c => c.Name == "Adventure"),
                        }
                    },
                    new Game
                    {
                        Title = "while True: learn()",
                        Description = "You’re a machine learning specialist who makes neural networks but your cat seems to be better at it. Now you must solve puzzles to build a cat-to-human translation system. Earn a fortune, buy kickass cat outfits and learn how machine learning really works!",
                        DescriptionDE = "Sie sind ein Spezialist für maschinelles Lernen, der neuronale Netze herstellt, aber Ihre Katze scheint darin besser zu sein. Jetzt müssen Sie Rätsel lösen, um ein Übersetzungssystem von Katze zu Mensch aufzubauen. Verdienen Sie ein Vermögen, kaufen Sie tolle Katzen-Outfits und erfahren Sie, wie maschinelles Lernen wirklich funktioniert!",
                        DescriptionUA = "Ви фахівець з машинного навчання, який створює нейронні мережі, але ваш кіт, здається, краще в цьому. Тепер ви повинні розгадати головоломки, щоб побудувати систему перекладу від кішки до людини. Заробляйте статки, купуйте наряди для котів і дізнайтеся, як насправді працює машинне навчання!",
                        ImageLink = "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_whileTruelearn_Ludenio_S2_1200x1600-f1259b2f801db59d751dd5e5076b6330?h=854&resize=1&w=640",
                        Price = 189,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Simulation"),
                        }
                    },
                    new Game
                    {
                        Title = "VALORANT",
                        Description = "VALORANT is a character-based 5v5 tactical shooter set on the global stage. Outwit, outplay, and outshine your competition with tactical abilities, precise gunplay, and adaptive teamwork.",
                        DescriptionDE = "VALORANT ist ein charakterbasierter 5v5-Taktik-Shooter, der auf der globalen Bühne spielt. Überliste, überliste und übertreffe deine Konkurrenz mit taktischen Fähigkeiten, präzisem Waffenspiel und adaptiver Teamarbeit.",
                        DescriptionUA = "VALORANT — це тактичний шутер 5 на 5, який розгортається на світовій арені. Перехитрите, переграйте та затьмаріть своїх конкурентів за допомогою тактичних здібностей, точної гри та адаптивної командної роботи.",
                        ImageLink = "https://cdn1.epicgames.com/offer/cbd5b3d310a54b12bf3fe8c41994174f/EGS_VALORANT_RiotGames_S2_1200x1600-d8903ac1a9ed2df31cdc223e23245a7d?h=854&resize=1&w=640",
                        Price = 0,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Action"),
                        }
                    },
                    new Game
                    {
                        Title = "Chivalry 2",
                        Description = "Chivalry 2 is a multiplayer first person slasher inspired by epic medieval movie battles. Players are thrust into the action of every iconic moment of the era - from clashing swords, to storms of flaming arrows, to sprawling castle sieges and more.",
                        DescriptionDE = "Chivalry 2 ist ein Multiplayer-Ego-Slasher, der von epischen mittelalterlichen Filmschlachten inspiriert wurde. Die Spieler werden in jeden ikonischen Moment der Ära hineingeschleust – von kollidierenden Schwertern über Stürme flammender Pfeile bis hin zu weitläufigen Burgbelagerungen und mehr.",
                        DescriptionUA = "Chivalry 2 — це багатокористувацький слешер від першої особи, натхненний епічними середньовічними битвами. Гравці втягуються в дію кожного знакового моменту епохи – від зіткнення мечів, до шторму полум’яних стріл, до облоги замків тощо.",
                        ImageLink = "https://cdn1.epicgames.com/offer/bd46d4ce259349e5bd8b3ded20274737/EGS_Chivalry2_TornBannerStudios_S2_1200x1600-eb2e6db88cbcc42e13c091eb8a656a29?h=854&resize=1&w=640",
                        Price = 569,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Fighting"),
                        }
                    },
                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        Description = "Winner of over 175 Game of the Year Awards and recipient of over 250 perfect scores, Red Dead Redemption 2 is an epic tale of honor and loyalty at the dawn of the modern age. Includes Red Dead Redemption 2: Story Mode and Red Dead Online.",
                        DescriptionDE = "Als Gewinner von über 175 Game of the Year Awards und Empfänger von über 250 perfekten Ergebnissen ist Red Dead Redemption 2 eine epische Geschichte über Ehre und Loyalität zu Beginn der Neuzeit. Enthält Red Dead Redemption 2: Story-Modus und Red Dead Online.",
                        DescriptionUA = "Володар понад 175 нагород «Гра року» та одержувач понад 250 ідеальних балів, Red Dead Redemption 2 — це епічна історія честі та вірності на зорі сучасності. Включає Red Dead Redemption 2: Story Mode і Red Dead Online.",
                        ImageLink = "https://cdn1.epicgames.com/epic/offer/RDR2PC1227_Epic%20Games_860x1148-860x1148-b4c2210ee0c3c3b843a8de399bfe7f5c.jpg?h=854&resize=1&w=640",
                        Price = 899,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Action"),
                            context.Categories.First(c => c.Name == "Open world"),
                        }
                    },
                    new Game
                    {
                        Title = "STAR WARS Battlefront II: Celebration Edition",
                        Description = "Put your mastery of the blaster, lightsaber, and the Force to the test online and offline in STAR WARS™ Battlefront™ II: Celebration Edition",
                        DescriptionDE = "Testen Sie Ihre Beherrschung des Blasters, des Lichtschwerts und der Macht online und offline in STAR WARS™ Battlefront™ II: Celebration Edition",
                        DescriptionUA = "Перевірте своє володіння бластером, світловим мечем і Силою онлайн та офлайн у STAR WARS™ Battlefront™ II: Celebration Edition",
                        ImageLink = "https://cdn1.epicgames.com/b156c3365a5b4cb9a01a5e1108b4e3f4/offer/EGS_STARWARSBattlefrontIICelebrationEdition_DICE_S2-1200x1600-11d040719a8457bbf36cabbe89b200db.jpg?h=854&resize=1&w=640",
                        Price = 1199,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Action"),
                            context.Categories.First(c => c.Name == "Adventure"),
                        }
                    },
                    new Game
                    {
                        Title = "League of Legends",
                        Description = "Become a legend. Find your champion, master their abilities, and outplay your opponents in an epic 5v5 battle to destroy the enemy base.",
                        DescriptionDE = "Eine Legende werden. Finden Sie Ihren Champion, beherrschen Sie seine Fähigkeiten und schlagen Sie Ihre Gegner in einem epischen 5v5-Kampf aus, um die feindliche Basis zu zerstören.",
                        DescriptionUA = "Стати легендою. Знайдіть свого чемпіона, оволодійте його здібностями та переграйте своїх супротивників у епічній битві 5 на 5, щоб знищити базу противника.",
                        ImageLink = "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_LeagueofLegends_RiotGames_S2_1200x1600-7fd64f0f7b674900bdd172967865d545?h=854&resize=1&w=640",
                        Price = 0,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Action"),
                            context.Categories.First(c => c.Name == "RPG"),
                            context.Categories.First(c => c.Name == "Strategy"),
                        }
                    },
                    new Game
                    {
                        Title = "Overcooked! 2",
                        Description = "Overcooked returns with a brand-new helping of chaotic cooking action! Journey back to the Onion Kingdom and assemble your team of chefs in classic couch co-op or online play for up to four players. Hold onto your aprons … it’s time to save the world (again!)",
                        DescriptionDE = "Overcooked kehrt mit einer brandneuen Portion chaotischer Kochaktion zurück! Reise zurück ins Zwiebelkönigreich und stelle dein Team von Köchen im klassischen Couch-Koop- oder Online-Spiel für bis zu vier Spieler zusammen. Halte deine Schürzen fest … es ist Zeit, die Welt (wieder) zu retten!",
                        DescriptionUA = "Overcooked повертається з абсолютно новою порцією хаотичного приготування! Поверніться до Цибулевого королівства та зберіть свою команду кухарів у класичній кооперативі на дивані або онлайн-грі для чотирьох гравців. Тримайте фартухи… настав час рятувати світ (знову!)",
                        ImageLink = "https://cdn1.epicgames.com/salesEvent/salesEvent/egs-overcooked2-tall_1200x1600-fbae89fad70c05cd1979316f620e64a9?h=854&resize=1&w=640",
                        Price = 419,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Co-op"),
                            context.Categories.First(c => c.Name == "Simulation"),
                        }
                    },
                    new Game
                    {
                        Title = "Cities: Skylines",
                        Description = "Cities: Skylines is a modern take on the classic city simulation. It introduces new gameplay elements to realize the thrill and hardships of creating and maintaining a real city whilst expanding on some well-established tropes of the city building experience.",
                        DescriptionDE = "Cities: Skylines ist eine moderne Version der klassischen Stadtsimulation. Es führt neue Gameplay-Elemente ein, um den Nervenkitzel und die Schwierigkeiten beim Erstellen und Erhalten einer echten Stadt zu erkennen und gleichzeitig einige etablierte Tropen des Städtebaus zu erweitern",
                        DescriptionUA = "Cities: Skylines — це сучасний погляд на класичний симулятор міста. Він представляє нові елементи ігрового процесу, щоб усвідомити хвилювання та труднощі створення та підтримки справжнього міста, одночасно розширюючи деякі усталені тропи досвіду будівництва міста.",
                        ImageLink = "https://cdn1.epicgames.com/6009be9994c2409099588cde6f3a5ed0/offer/EGS_CitiesSkylines_ColossalOrder_S2-1200x1600-753257537706de74735d2bc3eb656b67.jpg?h=854&resize=1&w=640",
                        Price = 379,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Simulation"),
                        }
                    },
                    new Game
                    {
                        Title = "Assassin's Creed Valhalla",
                        Description = "Become a legendary Viking on a quest for glory. Raid your enemies, grow your settlement, and build your political power.",
                        DescriptionDE = "Werde ein legendärer Wikinger auf der Suche nach Ruhm. Überfallen Sie Ihre Feinde, bauen Sie Ihre Siedlung aus und bauen Sie Ihre politische Macht aus.",
                        DescriptionUA = "Станьте легендарним вікінгом у пошуках слави. Здійснюйте набіги на своїх ворогів, розвивайте своє поселення та створюйте свою політичну владу.",
                        ImageLink = "https://cdn1.epicgames.com/400347196e674de89c23cc2a7f2121db/offer/AC%20KINGDOM%20PREORDER_STANDARD%20EDITION_EPIC_Key_Art_Portrait_640x854-640x854-288120c5573756cb988b6c1968cebd86.png?h=854&resize=1&w=640",
                        Price = 915,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Action"),
                            context.Categories.First(c => c.Name == "RPG"),
                            context.Categories.First(c => c.Name == "Open World"),
                        }
                    },
                    new Game
                    {
                        Title = "The Escapists 2",
                        Description = "Risk it all to breakout from the toughest prisons in the world. Explore the biggest prisons yet! You’ll have to live by the prison rules, attending roll call, doing prison jobs and following strict routines; all the while engineering your bid for freedom!",
                        DescriptionDE = "Riskieren Sie alles, um aus den härtesten Gefängnissen der Welt auszubrechen. Erkunde die bisher größten Gefängnisse! Sie müssen sich an die Gefängnisregeln halten, an einem Appell teilnehmen, Gefängnisjobs erledigen und strengen Routinen folgen. während Sie Ihr Streben nach Freiheit konstruieren!",
                        DescriptionUA = "Ризикуйте всім, щоб вирватися з найжорсткіших в’язниць світу. Дослідіть найбільші тюрми! Вам доведеться жити за тюремними правилами, відвідувати перекличку, виконувати тюремну роботу та дотримуватися суворого розпорядку; весь час розробляючи свою ставку на свободу!",
                        ImageLink = "https://cdn1.epicgames.com/115577f4ef1e4055aaf0da534fdfe81e/offer/egs-theescapists2-team17andmouldytoofstudios-s6-510x680-510x680-22e26fa7753b9b80df8d3ec01dee3e2f.jpg?h=854&resize=1&w=640",
                        Price = 299,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Simulation"),
                            context.Categories.First(c => c.Name == "Strategy"),
                        }
                    },
                    new Game
                    {
                        Title = "The Witcher 3: Wild Hunt - Game of the Year Edition",
                        Description = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.",
                        DescriptionDE = "Während der Krieg in den nördlichen Reichen weiter wütet, nehmen Sie den größten Auftrag Ihres Lebens an – das Kind der Prophezeiung aufzuspüren, eine lebende Waffe, die die Form der Welt verändern kann.",
                        DescriptionUA = "Поки в Північних Королівствах триває війна, ви берете на себе найбільшу угоду у своєму житті — вишукуєте Дитя Пророцтва, живу зброю, яка може змінити форму світу.",
                        ImageLink = "https://cdn1.epicgames.com/14ee004dadc142faaaece5a6270fb628/offer/EGS_TheWitcher3WildHuntGameoftheYear_CDPROJEKTRED_S2-1200x1600-d887e1b749d11e8876996227e4de5c89.jpg?h=854&resize=1&w=640",
                        Price = 579,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Adventure"),
                            context.Categories.First(c => c.Name == "Open World"),
                            context.Categories.First(c => c.Name == "RPG"),
                        }
                    },
                    new Game
                    {
                        Title = "House Flipper",
                        Description = "House Flipper is a unique chance to become a one-man renovation crew. Buy, repair and remodel devastated houses. Give them a second life and sell them at a profit!",
                        DescriptionDE = "House Flipper ist eine einzigartige Chance, ein Ein-Mann-Renovierungsteam zu werden. Kaufe, repariere und renoviere zerstörte Häuser. Geben Sie ihnen ein zweites Leben und verkaufen Sie sie mit Gewinn!",
                        DescriptionUA = "House Flipper — це унікальний шанс стати окремою бригадою з ремонту. Купуйте, ремонтуйте та реконструюйте зруйновані будинки. Подаруйте їм друге життя і продайте їх з прибутком!",
                        ImageLink = "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_HouseFlipper_Empyrean_S2_1200x1600-d15f9b26eab4f24fc9ba2913054d141f?h=854&resize=1&w=640",
                        Price = 279,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Casual"),
                            context.Categories.First(c => c.Name == "Simulation"),
                        }
                    },
                    new Game
                    {
                        Title = "Train Sim World 2",
                        Description = "The evolution of train simulation! Master iconic locomotives on high-speed services, long freight hauls or precise commuter traffic, and get creative with customisation tools in this advanced sequel. Climb into the cab in Train Sim World 2.",
                        DescriptionDE = "Die Evolution der Zugsimulation! Meistern Sie ikonische Lokomotiven auf Hochgeschwindigkeitsstrecken, langen Güterstrecken oder präzisem Pendlerverkehr und werden Sie in dieser fortschrittlichen Fortsetzung mit Anpassungswerkzeugen kreativ. Steigen Sie in Train Sim World 2 in das Taxi.",
                        DescriptionUA = "Еволюція симуляції поїзда! Опануйте культові локомотиви на високошвидкісних перевезеннях, тривалих вантажних перевезеннях або точних приміських перевезеннях і будьте креативними з інструментами налаштування в цьому розширеному продовженні. Сядьте в кабіну в Train Sim World 2.",
                        ImageLink = "https://cdn1.epicgames.com/salesEvent/salesEvent/home_1200x1600-51d687111b28dabec4b4706e35f22dd6?h=854&resize=1&w=640",
                        Price = 379,
                        Categories = new List<Category>
                        {
                            context.Categories.First(c => c.Name == "Simulation"),
                        }
                    }
                 );
            }
            context.SaveChanges();
        }
    }
}
