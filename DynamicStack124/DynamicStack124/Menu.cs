namespace DynamicStack124
{
    static class Menu
    {
        private static readonly string _mainMenu = 
            "Доступные команды:\n" +
            "1) Добавление в стек.\n" +
            "2) Удаление из стека.\n" +
            "3) Вывод основного стека.\n" +
            "4) Вывод стека удаленных эелементов.\n" +
            "5) Выйти из программы.\n";
        //Раздел 1
        private static readonly string _addMenu =
            "1) Добавить новый элемент.\n" +
            "2) Добавить элемент из вспомогательного стека.\n" +
            "3) Назад.\n";

        private static readonly string _addSecElement =
            "Верхний элемент из вспомогательного стека добавлен -> ";
        
        private static readonly string _addRangeSecElement =
            "Верхние элементы из вспомогательного стека добавлены -> ";

        private static readonly string _addMenuSec =
            "1) Добавить один элемент\n" +
            "2) Добавить несколько элементов\n" +
            "3) Назад\n";

        private static readonly string _addMenuNew =
            "1) Добавить один элемент\n" +
            "2) Добавить несколько элементов\n" +
            "3) Назад\n";

        private static readonly string _addRangeNewElement =
            "Введите числа через пробел, которые хотите добавить -> ";

        private static readonly string _addNewElement =
            "Введите число, которй хотите добавить -> ";

        //Раздел 2
        private static readonly string _delMenu =
            "1) Удалить элемент безвозвратно.\n" +
            "2) Удалить элемент и добавить его в стек удаленных элементов.\n" +
            "3) Назад.\n";

        private static readonly string _delMenuForever =
            "1) Удалить один элемент.\n" +
            "2) Удалить несколько элементов.\n" +
            "3) Назад.\n";

        private static readonly string _delForever =
            "Элемент удален безвозвратно : ";

        private static readonly string _delRangeForever =
            "Элементы удалены безвозвратно : ";
        private static readonly string _delMenuTemporarily =
            "1) Удалить один элемент временно.\n" +
            "2) Удалить несколько элементов временно.\n" +
            "3) Назад.\n";

        private static readonly string _delTemporarily =
            "Элемент удален и перемещен стек удаленных элементов :";
        private static readonly string _delRangeTemporarily =
            "Элементы удалены и перемещены в стек удаленных элементов :";
        //Раздел 3
        private static readonly string _createSecStack =
            "Введите количество элементов стека(элементы будут сгенерированы случайно)";
        //Раздел 4
        private static readonly string _outputMainStack =
            "Элементы основного стека:\n";
        //Раздел 5
        private static readonly string _outputRemevedStack =
            "Стек удаленных элементов:\n";
        //Раздел 6
        private static readonly string _outputSecStack =
            "Элементы вспомогательных списков:\n";
        
        
        public static string PrintMainMenu() => _mainMenu;
        
        public static string PrintAddMenu() => _addMenu;
        public static string PrintAddMenuSec() => _addMenuSec;
        public static string PrintAddSecElement() => _addSecElement;
        public static string PrintAddRangeSecElement() => _addRangeSecElement;
        public static string PrintAddMenuNew() => _addMenuNew;
        public static string PrintAddNewElement() => _addNewElement;
        public static string PrintAddRangeNewElement() => _addRangeNewElement;

        public static string PrintDelMenu() => _delMenu;
        public static string PrintDelForeverMenu() => _delMenuForever;
        public static string PrintDelForever() => _delForever;
        public static string PrintDelRangeForever() => _delRangeForever;
        public static string PrintDelTemporarilyMenu() => _delMenuTemporarily;
        public static string PrintDelTemporarily() => _delTemporarily;
        public static string PrintDelRangeTemporarily() => _delRangeTemporarily;
        
        public static string PrintCreateSecStack() => _createSecStack;
        
        public static string PrintOutputMainStack() => _outputMainStack;
        
        public static string PrintOutputRemevedStack() => _outputRemevedStack;
        
        public static string PrintOutputSecStack() => _outputSecStack;
    }
}