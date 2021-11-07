
export const initialState = {
    catalogPage: {
        products: {
            productsList: [],
            pagination: [],
            currentPage: 1,
        },
        filters: {
            category1: "Vitamins",
            category2: "",
            sort: "",
            brand: "",
            minPrice: 5,
            maxPrice: 11,
        },
        categories1: ["a"],
        brands: ["b"],
    },
    uiFlags:{
        loginFormFlag: false,
        registrationFormFlag: false,
        leftBurgerFlag: false,
        thankfulnessPopUpFlag: false,
        signInUpHolder: false,
    },
    userData: {
        isAuthenticated: false,
        userId: "",
        userName: "",
        userEmail: "",
        userPhoneNumber: "",
        OrdersPage: {Orders: ""},
        LikesPage: {Likes: ""},
        ViewedProductsPage: {ViewedProducts: ""},
        CommentsPage: {Comments: ""},
        ProfilePage: {Profile: ""},
    },
    cart: {},
    productPageViewModel: {
        id: 10,
        name: "Now Foods, Glutathione, 500 mg, 60 Veg Capsules",
        imgUrl: "",
        categoryFirstLvl: {
            id: 1,
            valueEn: "Vitamins",
            valueRu: "Вітаміни",
            valueUk: "Вітаміни"
        },
        categorySecondLvl: {
            id: 1,
            valueEn: "Vitamins",
            valueRu: "Вітаміни",
            valueUk: "Вітаміни"
        },
        brand: "Now Foods",
        priceUSD: 26.12,
        popularity: 0,
        info: {
            id: 6,
            productId: 10,
            lang: 2,
            shortDescription: {
                id: 351,
                value: "Глутатіон&nbsp;— це невелика пептидна молекула, що складається з трьох амінокислот: цистеїну, глутамінової кислоти та гліцину. Він виробляється кожною клітиною організму. Особливо його багато в печінці. Глутатіон має вирішальне значення для здорової роботи імунної системи й необхідний для належної детоксикації. Він також відіграє головну роль у підтримці здоров’я клітин шляхом безпосередньої нейтралізації вільних радикалів, а також завдяки підтримці активності вітамінів&nbsp;С та Е. Екстракт розторопші та альфа-ліпоєва кислота включені як допоміжні інгредієнти."
            },
            descriptionsLi: [
                {
                    id: 3677,
                    value: "Дієтична добавка"
                },
                {
                    id: 3678,
                    value: "Без ГМО"
                },
                {
                    id: 3679,
                    value: "З екстрактом розторопші й альфа-ліпоєвою кислотою"
                },
                {
                    id: 3680,
                    value: "Відновлена активна форма"
                },
                {
                    id: 3681,
                    value: "Нейтралізатор вільних радикалів"
                },
                {
                    id: 3699,
                    value: "Вегетаріанський і веганський продукт"
                },
                {
                    id: 3749,
                    value: "Кошерний продукт"
                },
                {
                    id: 3750,
                    value: "Сімейне підприємство з 1968&nbsp;року"
                },
                {
                    id: 3797,
                    value: "Амінокислоти"
                },
                {
                    id: 3818,
                    value: ""
                },
                {
                    id: 3819,
                    value: "Виготовлено на підприємстві, що має реєстрацію GMP"
                }
            ],
            dopDescriptions: [
                {
                    id: 3813,
                    value: "\n<h3>\n<strong>Рекомендації із застосування</strong>\n</h3>\n<div class=\"prodOverviewDetail\">\n<p>Приймати по 1&nbsp;капсулі на день, бажано натщесерце.</p>\n                                                </div>\n                                            "
                },
                {
                    id: 3814,
                    value: "\n<h3>\n<strong>Інші інгредієнти</strong>\n</h3>\n<div class=\"prodOverviewIngred\"><p>Гіпромелоза (целюлозна капсула), мікрокристалічна целюлоза, стеарат магнію (рослинного походження) і діоксид кремнію.</p><p>Для виготовлення цього продукту не використовуються пшениця, глютен, соя, молоко, яйця, риба, молюски та деревні горіхи. Виготовляється на підприємстві, яке має реєстрацію належної виробничої практики (GMP), де обробляються інші інгредієнти, що містять ці алергени.</p><br></div>\n                                            "
                },
                {
                    id: 3815,
                    value: "\n<h3>\n<strong>Попередження</strong>\n</h3>\n<div class=\"prodOverviewDetail\"><p>Після відкривання упаковки зберігати в сухому прохолодному місці.</p><p>Тільки для дорослих. Перед початком застосування в період вагітності, грудного вигодовування, за наявності захворювань або під час прийому препаратів слід проконсультуватися з лікарем. Зберігати в недоступному для дітей місці.</p><p>Колір продукту може змінюватися природним чином.<br></p></div>\n                                            "
                },
                {
                    id: 3816,
                    value: "\n<h3>\n<strong>Застереження</strong>\n</h3>\n<div id=\"disclaimer\" class=\"prodOverviewDetail\">\n<p>iHerb прагне забезпечити точність зображень товарів та інформації про них, але для деяких змін, внесених виробником в упаковку та/або інгредієнти, може очікуватись оновлення на нашому сайті. Хоча іноді товари можуть надходити з альтернативною упаковкою, свіжість завжди гарантована. Рекомендуємо перед використанням ознайомитися з інформацією на етикетках, попередженнями та вказівками до всіх товарів, а не покладатися виключно на інформацію, надану iHerb.</p>\n                                            </div>\n                                        "
                },
                {
                    id: 3817,
                    value: "\n<a target=\"_blank\" rel=\"nofollow\" href=\"http://www.nowfoods.com/\">\n                                                    <strong class=\"link-lg\">Перейти на сайт виробника</strong>\n                                                </a>\n                                            "
                }
            ],
            table: [
                {
                    id: 14201,
                    firstColumn: "**&nbsp;Добову норму не визначено",
                    secondColumn: "",
                    thirdColumn: ""
                },
                {
                    id: 14202,
                    firstColumn: "Альфа-ліпоєва кислота",
                    secondColumn: "50&nbsp;мг",
                    thirdColumn: "**"
                },
                {
                    id: 14203,
                    firstColumn: "Екстракт розторопші (Silybum marianum) (плоди/насіння) (стандартизований до&nbsp;80&nbsp;мг силімаринових флавоноїдів&nbsp;— еквівалент 80&nbsp;%)",
                    secondColumn: "100&nbsp;мг",
                    thirdColumn: "**"
                },
                {
                    id: 14204,
                    firstColumn: "Глутатіон (відновлена форма)<br>",
                    secondColumn: "500&nbsp;мг",
                    thirdColumn: "**"
                },
                {
                    id: 14205,
                    firstColumn: " ",
                    secondColumn: "<strong>Кількість в 1&nbsp;порції</strong>",
                    thirdColumn: "<strong>% від добової норми</strong>"
                },
                {
                    id: 14206,
                    firstColumn: "<strong>Розмір порції:</strong> 1&nbsp;вегетаріанська капсула",
                    secondColumn: "",
                    thirdColumn: ""
                },
                {
                    id: 14207,
                    firstColumn: "<strong>Поживна цінність</strong>",
                    secondColumn: "",
                    thirdColumn: ""
                }
            ]
        },
        productAmountOrderInput: 1,
        isIncrementButtonDisabled: false,
        isDecrementButtonDisabled: false,
        amount: 5,
    }
}


// registrationPage: {
//     nameInput: "a",
//     emailInput: "",
//     phoneInput: "a",
//     passwordInput: "a",
//     passwordConfirmInput: "a",
// },