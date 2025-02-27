namespace Ratatouille.Data
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string DescrizioneBreve { get; set; }
        public string Ingredienti { get; set; }
        public string Procedimento { get; set; }
        public string ImmagineUrl { get; set; }
    
        public static List<Recipe> GetRecipeList()
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Titolo = "Pasta alla Carbonara",
                    DescrizioneBreve = "Classica ricetta romana con uova e guanciale",
                    Ingredienti = "Spaghetti, Guanciale, Uova, Pecorino Romano, Pepe",
                    Procedimento = "Cuoci gli spaghetti. Nel frattempo, rosola il guanciale in padella...",
                    ImmagineUrl = "https://www.mamablip.com/storage/Traditional-Spaghetti-alla-Carbonara_1131611747132.jpg"
                },
                new Recipe
                {
                    Id = 2,
                    Titolo = "Pizza Margherita",
                    DescrizioneBreve = "La regina delle pizze: pomodoro, mozzarella e basilico",
                    Ingredienti = "Farina, Lievito, Acqua, Pomodoro, Mozzarella, Basilico",
                    Procedimento = "Prepara l'impasto e lascialo lievitare. Condisci con pomodoro e mozzarella...",
                    ImmagineUrl = "https://it.ooni.com/cdn/shop/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800"
                },
                new Recipe
                {
                    Id = 3,
                    Titolo = "Lasagne alla Bolognese",
                    DescrizioneBreve = "Strati di pasta all'uovo, ragù e besciamella",
                    Ingredienti = "Sfoglie di pasta, Ragù di carne, Besciamella, Parmigiano",
                    Procedimento = "Alterna strati di sfoglia, ragù, besciamella e parmigiano. Inforna...",
                    ImmagineUrl = "https://assets.epicurious.com/photos/54ad692d6529d92b2c0464f5/4:3/w_672,h_504,c_limit/51193620_lasagne-bolognese_1x1.jpg"
                },
                new Recipe
                {
                    Id = 4,
                    Titolo = "Risotto ai Funghi",
                    DescrizioneBreve = "Un primo piatto cremoso a base di funghi porcini",
                    Ingredienti = "Riso Carnaroli, Funghi porcini, Brodo vegetale, Burro, Parmigiano",
                    Procedimento = "Tosta il riso con un soffritto leggero, aggiungi i funghi e il brodo caldo...",
                    ImmagineUrl = "https://www.risotto.us/wp-content/uploads/2021/11/porcini-e-salsiccia.jpg"
                },
                new Recipe
                {
                    Id = 5,
                    Titolo = "Parmigiana di Melanzane",
                    DescrizioneBreve = "Melanzane fritte alternate a pomodoro e mozzarella",
                    Ingredienti = "Melanzane, Passata di pomodoro, Mozzarella, Parmigiano, Basilico",
                    Procedimento = "Friggi le fette di melanzana, poi crea strati con salsa di pomodoro...",
                    ImmagineUrl = "https://www.cuochemabuone.it/wp-content/uploads/2023/07/parmigiana-di-melanzane.jpg"
                },
                new Recipe
                {
                    Id = 6,
                    Titolo = "Pollo al Forno con Patate",
                    DescrizioneBreve = "Un secondo piatto semplice e gustoso",
                    Ingredienti = "Pollo, Patate, Rosmarino, Olio, Sale, Pepe",
                    Procedimento = "Condisci il pollo e le patate con olio, sale, pepe e rosmarino...",
                    ImmagineUrl = "https://ricetta.it/Uploads/Imgs/pollo-al-forno.jpg.webp"
                },
                new Recipe
                {
                    Id = 7,
                    Titolo = "Spaghetti allo Scoglio",
                    DescrizioneBreve = "Pasta di mare con vongole, cozze e gamberi",
                    Ingredienti = "Spaghetti, Vongole, Cozze, Gamberi, Pomodorini, Prezzemolo",
                    Procedimento = "Fai aprire le vongole e le cozze, poi aggiungi i gamberi e i pomodorini...",
                    ImmagineUrl = "https://www.melarossa.it/wp-content/uploads/2021/03/spaghetti-allo-scoglio.jpg"
                },
                new Recipe
                {
                    Id = 8,
                    Titolo = "Bruschetta al Pomodoro",
                    DescrizioneBreve = "Antipasto veloce con pomodoro fresco e basilico",
                    Ingredienti = "Pane, Pomodori, Aglio, Olio EVO, Basilico, Sale",
                    Procedimento = "Tosta le fette di pane, strofinale con l'aglio, poi aggiungi pomodoro e basilico...",
                    ImmagineUrl = "https://primochef.it/wp-content/uploads/2019/09/SH_bruschetta_al_pomodoro.jpg"
                },
                new Recipe
                {
                    Id = 9,
                    Titolo = "Filetto di Manzo",
                    DescrizioneBreve = "Taglio pregiato di carne, ottimo al sangue o media cottura",
                    Ingredienti = "Filetto di manzo, Olio, Burro, Sale, Pepe",
                    Procedimento = "Scalda bene la padella, sigilla il filetto su entrambi i lati...",
                    ImmagineUrl = "https://cdn.ilclubdellericette.it/wp-content/uploads/2019/06/filetto-di-manzo-640x480.jpg"
                },
                new Recipe
                {
                    Id = 10,
                    Titolo = "Caponata Siciliana",
                    DescrizioneBreve = "Piatto tipico a base di melanzane e verdure in agrodolce",
                    Ingredienti = "Melanzane, Sedano, Cipolla, Pomodoro, Olive, Capperi, Aceto, Zucchero",
                    Procedimento = "Taglia le verdure a dadini, friggile e poi cuocile con pomodoro e agrodolce...",
                    ImmagineUrl = "https://media-assets.lacucinaitaliana.it/photos/620fbf79a4d64e19087d8bb6/1:1/w_2560%2Cc_limit/empty"
                },
                new Recipe
                {
                    Id = 11,
                    Titolo = "Salmone al Forno",
                    DescrizioneBreve = "Filetto di salmone semplice e veloce da preparare",
                    Ingredienti = "Salmone, Limone, Olio EVO, Sale, Pepe",
                    Procedimento = "Disponi il salmone in teglia, condiscilo con olio, limone, sale e pepe...",
                    ImmagineUrl = "https://www.cucchiaio.it/content/dam/cucchiaio/it/ricette/2021/11/salmone-marinato-al-forno-con-dadolata-di-verdure/salmone-marinato-ape.jpg"
                },
                new Recipe
                {
                    Id = 12,
                    Titolo = "Pesto alla Genovese",
                    DescrizioneBreve = "Salsa a base di basilico, pinoli e parmigiano",
                    Ingredienti = "Basilico fresco, Pinoli, Parmigiano, Olio EVO, Aglio, Sale",
                    Procedimento = "Pesta (o frulla) il basilico con pinoli, parmigiano, aglio e olio fino a ottenere una crema...",
                    ImmagineUrl = "https://www.foodandwine.com/thmb/iXSUEXtBTltiWfA_WYF3gfar96o=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Pesto-Genovese-Classic-Basil-Pesto-FT-RECIPE0623-1bc85b167aec40759086d4fbb89ba8f4.jpg"
                },
                new Recipe
                {
                    Id = 13,
                    Titolo = "Focaccia",
                    DescrizioneBreve = "Impasto soffice, ottimo come spuntino o antipasto",
                    Ingredienti = "Farina, Lievito, Acqua, Olio, Sale",
                    Procedimento = "Prepara l'impasto, lascialo lievitare e poi stendilo in teglia con olio e sale...",
                    ImmagineUrl = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/6E729D6A-ADFA-4492-AE57-0E3BE1F8D945/Derivates/F5669723-EBDF-444C-BBB1-B54F1AB1D8F7.jpg"
                },
                new Recipe
                {
                    Id = 14,
                    Titolo = "Tiramisù",
                    DescrizioneBreve = "Classico dessert al caffè con mascarpone e savoiardi",
                    Ingredienti = "Savoiardi, Mascarpone, Uova, Zucchero, Caffè, Cacao amaro",
                    Procedimento = "Monta uova e zucchero, aggiungi il mascarpone, poi alterna savoiardi inzuppati nel caffè...",
                    ImmagineUrl = "https://www.cucchiaio.it/content/dam/cucchiaio/it/ricette/2023/08/tiramisu-cremoso/tiramisu-cremoso-finale.jpg"
                },
                new Recipe
                {
                    Id = 15,
                    Titolo = "Polpette al Sugo",
                    DescrizioneBreve = "Polpette di carne immerse in un sugo di pomodoro saporito",
                    Ingredienti = "Carne macinata, Uova, Pane, Latte, Pomodoro, Aglio, Cipolla",
                    Procedimento = "Prepara le polpette e falle rosolare, poi cuocile nel sugo di pomodoro per 20-30 minuti...",
                    ImmagineUrl = "https://www.cucchiaio.it/content/cucchiaio/it/ricette/2018/11/polpette-al-sugo/_jcr_content/header-par/image-single.img.jpg/1541764256677.jpg"
                }
            };
        }
    }
}
