using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pirozjki_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class ingredienti
        {
            public string cto;
            public string name;
            public int stoimost;
            public double ves;

            public ingredienti(string c, string n, int s, double v)
            {
                cto = c;
                name = n;
                stoimost = s;
                ves = v;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string y = textBox1.Text;

            if(y == "")
            {
                return;
            }

            int x = Convert.ToInt32(textBox1.Text);

            List<ingredienti> list = new List<ingredienti>();

            //-----------------------------------------
            //Подсчет Муки
            //-----------------------------------------

            list.Add(new ingredienti("Мука", "Мука Макфа пшеничная высший сорт", 50, 1000));
            //list.Add(new ingredienti("Мука", "Мука Макфа пшеничная высший сорт", 90, 2000));
            //list.Add(new ingredienti("Мука", "Мука Макфа пшеничная высший сорт", 155, 5000));
            //list.Add(new ingredienti("Мука", "Мука Макфа пшеничная высший сорт", 335, 10000));

            double myka = x * 25;
            double mykamas = 0;
            double mykasto = 0;

            ingredienti myk = list.FindAll(item => item.cto == "Мука").Find(item => item.ves >= 0);

            int mykpacket4 = 0;
            int mykpacket3 = 0;
            int mykpacket2 = 0;
            int mykpacket1 = 0;

            while (mykamas <= myka)
            {
                if ((myka - mykamas) > 8000)
                {
                    mykamas += 10000;
                    mykasto += 335;
                    mykpacket4++;
                }
                else
                {
                    if ((myka - mykamas) > 3000)
                    {
                        mykamas += 5000;
                        mykasto += 155;
                        mykpacket3++;
                    }
                    else
                    {
                        if ((myka - mykamas) > 1000)
                        {
                            mykamas += 2000;
                            mykasto += 90;
                            mykpacket2++;
                        }
                        else
                        {
                            if ((myka - mykamas) > 0)
                            {
                                mykamas += 1000;
                                mykasto += 50;
                                mykpacket1++;
                            }
                            else
                            {
                                if ((myka - mykamas) != 0)
                                {
                                    mykamas += 1000;
                                    mykasto += 50;
                                    mykpacket1++;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Дрожжи
            //-----------------------------------------

            list.Add(new ingredienti("Дрожжи", "Дрожжи Саф-Левюр сухие активные", 37, 50));
            //list.Add(new ingredienti("Дрожжи", "Дрожжи Саф-Левюр сухие активные", 70, 100));

            double droj = x * 0.32;
            double dromas = 0;
            double drosto = 0;

            ingredienti dro = list.FindAll(item => item.cto == "Дрожжи").Find(item => item.ves >= 0);

            int dropacket2 = 0;
            int dropacket1 = 0;

            while (dromas <= droj)
            {
                if ((droj - dromas) > 50)
                {
                    dromas += 100;
                    drosto += 70;
                    dropacket2++;
                }
                else
                {
                    if ((droj - dromas) > 0)
                    {
                        dromas += 50;
                        drosto += 37;
                        dropacket1++;
                    }
                    else
                    {
                        if ((droj - dromas) != 0)
                        {
                            dromas += 50;
                            drosto += 37;
                            dropacket1++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Сахар
            //-----------------------------------------

            list.Add(new ingredienti("Сахар", "Сахар Успенский сахарный завод Сахар-песок", 46, 1000));

            double sahar = x * 6.25;
            double sahmas = 0;
            double sahsto = 0;

            ingredienti sah = list.FindAll(item => item.cto == "Сахар").Find(item => item.ves >= 0);

            int sahpacket1 = 0;

            while (sahmas <= sahar)
            {
                if ((sahar - sahmas) > 0)
                {
                    sahmas += 1000;
                    sahsto += 46;
                    sahpacket1++;
                }
                else
                {
                    if ((sahar - sahmas) != 0)
                    {
                        sahmas += 1000;
                        sahsto += 46;
                        sahpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Соль
            //-----------------------------------------

            list.Add(new ingredienti("Соль", "Тыретский солерудник соль поваренная пищевая высший сорт", 13, 1000));

            double soli = x * 2.5;
            double solmas = 0;
            double solsto = 0;

            ingredienti sol = list.FindAll(item => item.cto == "Соль").Find(item => item.ves >= 0);

            int solpacket1 = 0;

            while (solmas <= soli)
            {
                if ((soli - solmas) > 0)
                {
                    solmas += 1000;
                    solsto += 13;
                    solpacket1++;
                }
                else
                {
                    if ((soli - solmas) != 0)
                    {
                        solmas += 1000;
                        solsto += 13;
                        solpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Молоко
            //-----------------------------------------

            list.Add(new ingredienti("Молоко", "Молоко Parmalat Natura Premium ультрапастеризованное 3.5%", 78, 1000));

            double milk = x * 12;
            double milmas = 0;
            double milsto = 0;

            ingredienti mil = list.FindAll(item => item.cto == "Молоко").Find(item => item.ves >= 0);

            int milpacket1 = 0;

            while (milmas <= milk)
            {
                if ((milk - milmas) > 0)
                {
                    milmas += 1000;
                    milsto += 78;
                    milpacket1++;
                }
                else
                {
                    if ((soli - solmas) != 0)
                    {
                        milmas += 1000;
                        milsto += 78;
                        milpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Яйцо
            //-----------------------------------------

            list.Add(new ingredienti("Яйцо", "Яйцо куриное Окское столовое С0", 85, 10));
            //list.Add(new ingredienti("Яйцо", "Яйцо куриное Окское столовое C0", 250, 30));

            double yaizo = x * 0.25;

            if (comboBox1.Text == "Лук и Яйцо")
            {
                double yaizaotvar = x * 0.3;
                yaizo = yaizo + yaizaotvar;
            } //При выборе ""Лук и Яйцо"" добавляются яйца

            double yaimas = 0;
            double yaisto = 0;

            ingredienti yai = list.FindAll(item => item.cto == "Яйцо").Find(item => item.ves >= 0);

            int yaipacket2 = 0;
            int yaipacket1 = 0;

            while (yaimas <= yaizo)
            {
                if ((yaizo - yaimas) > 20)
                {
                    yaimas += 30;
                    yaisto += 250;
                    yaipacket2++;
                }
                else
                {
                    if ((yaizo - dromas) > 0)
                    {
                        yaimas += 10;
                        yaisto += 85;
                        yaipacket1++;
                    }
                    else
                    {
                        if ((yaizo - dromas) != 0)
                        {
                            yaimas += 10;
                            yaisto += 85;
                            yaipacket1++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Сливочное масло
            //-----------------------------------------

            list.Add(new ingredienti("Сливочное масло", "Вкуснотеево Масло сливочное традиционное 82.5%", 155, 200));
            //list.Add(new ingredienti("Сливочное масло", "Вкуснотеево Масло сливочное традиционное 82.5%", 300, 400));

            double slivmaslo = x * 2;
            double slimas = 0;
            double slisto = 0;

            ingredienti sli = list.FindAll(item => item.cto == "Сливочное масло").Find(item => item.ves >= 0);

            int slipacket2 = 0;
            int slipacket1 = 0;

            while (slimas <= slivmaslo)
            {
                if ((slivmaslo - slimas) > 200)
                {
                    slimas += 400;
                    slisto += 300;
                    slipacket2++;
                }
                else
                {
                    if ((slivmaslo - slimas) > 0)
                    {
                        slimas += 200;
                        slisto += 155;
                        slipacket1++;
                    }
                    else
                    {
                        if ((yaizo - dromas) != 0)
                        {
                            slimas += 200;
                            slisto += 155;
                            slipacket1++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Растительное масло
            //-----------------------------------------

            list.Add(new ingredienti("Растительное масло", "Золотая Семечка масло подсолнечное", 54, 1000));

            double rastmaslo = x * 12;
            double rastmas = 0;
            double raststo = 0;

            ingredienti rast = list.FindAll(item => item.cto == "Растительное масло").Find(item => item.ves >= 0);

            int rastpacket1 = 0;

            while (rastmas <= rastmaslo)
            {
                if ((rastmaslo - rastmas) > 0)
                {
                    rastmas += 1000;
                    raststo += 54;
                    rastpacket1++;
                }
                else
                {
                    if ((rastmaslo - rastmas) != 0)
                    {
                        rastmas += 1000;
                        raststo += 54;
                        rastpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Капуста
            //-----------------------------------------

            list.Add(new ingredienti("Капуста", "Капуста белокочанная 2-3.5кг", 30, 3000));

            double kapysta = x * 20;
            double kapmas = 0;
            double kapsto = 0;

            ingredienti kap = list.FindAll(item => item.cto == "Капуста").Find(item => item.ves >= 0);

            int kappacket1 = 0;

            while (kapmas <= kapysta)
            {
                if ((kapysta - kapmas) > 0)
                {
                    kapmas += 3000;
                    kapsto += 30;
                    kappacket1++;
                }
                else
                {
                    if ((kapysta - kapmas) != 0)
                    {
                        kapmas += 3000;
                        kapsto += 30;
                        kappacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Мясо
            //-----------------------------------------

            list.Add(new ingredienti("Мясо", "Фарш Мираторг домашний из свинины и говядины", 159, 400));

            double myaso = x * 20;
            double myamas = 0;
            double myasto = 0;

            ingredienti mya = list.FindAll(item => item.cto == "Мясо").Find(item => item.ves >= 0);

            int myapacket1 = 0;

            while (myamas <= myaso)
            {
                if ((myaso - myamas) > 0)
                {
                    myamas += 400;
                    myasto += 159;
                    myapacket1++;
                }
                else
                {
                    if ((myaso - myamas) != 0)
                    {
                        myamas += 400;
                        myasto += 159;
                        myapacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Повидло
            //-----------------------------------------

            list.Add(new ingredienti("Повидло", "Просто Клубничное/Яблочное", 64, 500));

            double povidlo = x * 20;
            double povmas = 0;
            double povsto = 0;

            ingredienti pov = list.FindAll(item => item.cto == "Повидло").Find(item => item.ves >= 0);

            int povpacket1 = 0;

            while (povmas <= povidlo)
            {
                if ((povidlo - povmas) > 0)
                {
                    povmas += 500;
                    povsto += 64;
                    povpacket1++;
                }
                else
                {
                    if ((povidlo - povmas) != 0)
                    {
                        povmas += 500;
                        povsto += 64;
                        povpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Лук
            //-----------------------------------------

            list.Add(new ingredienti("Лук", "Лук зеленый", 18, 100));

            double lyk = x * 10;
            double lykmas = 0;
            double lyksto = 0;

            ingredienti ly = list.FindAll(item => item.cto == "Лук").Find(item => item.ves >= 0);

            int lykpacket1 = 0;

            while (lykmas <= lyk)
            {
                if ((lyk - lykmas) > 0)
                {
                    lykmas += 100;
                    lyksto += 18;
                    lykpacket1++;
                }
                else
                {
                    if ((lyk - lykmas) != 0)
                    {
                        lykmas += 100;
                        lyksto += 18;
                        lykpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //-----------------------------------------
            //Подсчет Картофель
            //-----------------------------------------

            list.Add(new ingredienti("Картофель", "Картофель", 35, 1000));

            double potato = x * 40;
            double potmas = 0;
            double potsto = 0;

            ingredienti pot = list.FindAll(item => item.cto == "Картофель").Find(item => item.ves >= 0);

            int potpacket1 = 0;

            while (potmas <= potato)
            {
                if ((potato - potmas) > 0)
                {
                    potmas += 1000;
                    potsto += 35;
                    potpacket1++;
                }
                else
                {
                    if ((potato - potmas) != 0)
                    {
                        potmas += 1000;
                        potsto += 35;
                        potpacket1++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            /*


            richTextBox1.Text = ($"" +
                        $"Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\nСухие дрожжи - {droj} г" +
                        $"\nСахар - {sahar} г" +
                        $"\nСоль - {soli} г" +
                        $"\nМолоко - {milk} мл." +
                        $"\nЯйцо - {yaizo} шт." +
                        $"\nСливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\nРастительное масло (для замеса теста) - {rastmaslo} мл" +
                        $"" +
                        $"" +
                        $"" +
                        $"\nКапуста - {kapysta} гр" +
                        $"\nМясо - {myaso} гр" +
                        $"\nПовидло - {povidlo} мл" +
                        $"\nЯйца отварные - {yaizaotvar} шт." +
                        $"\nЛук - {lyk} гр" +
                        $"\nКартофель - {potato} гр");

            richTextBox2.Text = ($"" +
                                $"{myk.name}, {mykasto} руб, {mykamas} г, {mykpacket1} {mykpacket2} {mykpacket3} {mykpacket4}" +
                                $"\n{dro.name}, {drosto} руб, {dromas} г, {dropacket1} {dropacket2}" +
                                $"\n{sah.name}, {sahsto} руб, {sahmas} г, {dropacket1}" +
                                $"\n{sol.name}, {solsto} руб, {solmas} г, {solpacket1}" +
                                $"\n{mil.name}, {milsto} руб, {milmas} г, {milpacket1}" +
                                $"\n{yai.name}, {yaisto} руб, {yaimas} г, {yaipacket1} {yaipacket2}" +
                                $"\n{sli.name}, {slisto} руб, {slimas} г, {slipacket1} {slipacket2}" +
                                $"\n{rast.name}, {raststo} руб, {rastmas} г, {rastpacket1}" +
                                $"\n{kap.name}, {kapsto} руб, {kapmas} г, {kappacket1}" +
                                $"\n{mya.name}, {myasto} руб, {myamas} г, {myapacket1}" +
                                $"\n{pov.name}, {povsto} руб, {povmas} г, {povpacket1}" +
                                $"\n{ly.name}, {lyksto} руб, {lykmas} г, {lykpacket1}" +
                                $"\n{pot.name}, {potsto} руб, {potmas} г, {potpacket1}");

            
                    richTextBox2.Text = ($"" +
                                $"{myk.name}, {mykasto} руб, {mykamas} г, {mykpacket1} {mykpacket2} {mykpacket3} {mykpacket4}" +
                                $"\n{dro.name}, {drosto} руб, {dromas} г, {dropacket1} {dropacket2}" +
                                $"\n{sah.name}, {sahsto} руб, {sahmas} г, {dropacket1}" +
                                $"\n{sol.name}, {solsto} руб, {solmas} г, {solpacket1}" +
                                $"\n{mil.name}, {milsto} руб, {milmas} г, {milpacket1}" +
                                $"\n{yai.name}, {yaisto} руб, {yaimas} г, {yaipacket1} {yaipacket2}" +
                                $"\n{sli.name}, {slisto} руб, {slimas} г, {slipacket1} {slipacket2}" +
                                $"\n{rast.name}, {raststo} руб, {rastmas} г, {rastpacket1}" +
                                $"\n{kap.name}, {kapsto} руб, {kapmas} г, {kappacket1}");

             richTextBox2.Text = ($"" +
                                $"{myk.name}, {mykasto} руб, {mykamas} г, {mykpacket1} {mykpacket2} {mykpacket3} {mykpacket4}" +
                                $"\n{dro.name}, {drosto} руб, {dromas} г, {dropacket1} {dropacket2}" +
                                $"\n{sah.name}, {sahsto} руб, {sahmas} г, {dropacket1}" +
                                $"\n{sol.name}, {solsto} руб, {solmas} г, {solpacket1}" +
                                $"\n{mil.name}, {milsto} руб, {milmas} г, {milpacket1}" +
                                $"\n{yai.name}, {yaisto} руб, {yaimas} г, {yaipacket1} {yaipacket2}" +
                                $"\n{sli.name}, {slisto} руб, {slimas} г, {slipacket1} {slipacket2}" +
                                $"\n{rast.name}, {raststo} руб, {rastmas} г, {rastpacket1}" +
                                $"\n{mya.name}, {myasto} руб, {myamas} г, {myapacket1}");


            */

            switch (comboBox1.Text)
            {
                case "Без начинки":

                    richTextBox1.Text = ($"" +
                        $" Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\n Сухие дрожжи - {droj} г" +
                        $"\n Сахар - {sahar} г" +
                        $"\n Соль - {soli} г" +
                        $"\n Молоко - {milk} мл." +
                        $"\n Яйцо - {yaizo} шт." +
                        $"\n Сливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\n Растительное масло (для замеса теста) - {rastmaslo} мл");

                    richTextBox2.Text = ($"" +
                        $" {myk.name}" +
                        $"\n {dro.name}" +
                        $"\n {sah.name}" +
                        $"\n {sol.name}" +
                        $"\n {mil.name}" +
                        $"\n {yai.name}" +
                        $"\n {sli.name}" +
                        $"\n {rast.name}");

                    richTextBox3.Text = ($"" +
                        $" {mykasto} руб" +
                        $"\n {drosto} руб" +
                        $"\n {sahsto} руб" +
                        $"\n {solsto} руб" +
                        $"\n {milsto} руб" +
                        $"\n {yaisto} руб" +
                        $"\n {slisto} руб" +
                        $"\n {raststo} руб");

                    richTextBox4.Text = ($"" +
                        $" {mykamas} г" +
                        $"\n {dromas} г" +
                        $"\n {sahmas} г" +
                        $"\n {solmas} г" +
                        $"\n {milmas} г" +
                        $"\n {yaimas} г" +
                        $"\n {slimas} г" +
                        $"\n {rastmas} г");

                    richTextBox5.Text = ($"" +
                        $" {mykpacket1} мал.уп. | {mykpacket2} ср.уп. | {mykpacket3} бол. уп. | {mykpacket4} очень бол. уп." +
                        $"\n {dropacket1} мал.уп. | {dropacket2} бол. уп." +
                        $"\n {dropacket1} уп." +
                        $"\n {solpacket1} уп." +
                        $"\n {milpacket1} уп." +
                        $"\n {yaipacket1} мал.уп. | {yaipacket2} бол. уп." +
                        $"\n {slipacket1} мал.уп. | {slipacket2} бол. уп." +
                        $"\n {rastpacket1} уп.");

                    break;

                case "Капуста":

                    richTextBox1.Text = ($"" +
                        $" Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\n Сухие дрожжи - {droj} г" +
                        $"\n Сахар - {sahar} г" +
                        $"\n Соль - {soli} г" +
                        $"\n Молоко - {milk} мл." +
                        $"\n Яйцо - {yaizo} шт." +
                        $"\n Сливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\n Растительное масло (для замеса теста) - {rastmaslo} мл" +
                        $"\n Капуста - {kapysta} гр");

                    richTextBox2.Text = ($"" +
                        $" {myk.name}" +
                        $"\n {dro.name}" +
                        $"\n {sah.name}" +
                        $"\n {sol.name}" +
                        $"\n {mil.name}" +
                        $"\n {yai.name}" +
                        $"\n {sli.name}" +
                        $"\n {rast.name}" +
                        $"\n {kap.name}");

                    richTextBox3.Text = ($"" +
                        $" {mykasto} руб" +
                        $"\n {drosto} руб" +
                        $"\n {sahsto} руб" +
                        $"\n {solsto} руб" +
                        $"\n {milsto} руб" +
                        $"\n {yaisto} руб" +
                        $"\n {slisto} руб" +
                        $"\n {raststo} руб" +
                        $"\n {kapsto} руб");

                    richTextBox4.Text = ($"" +
                        $" {mykamas} г" +
                        $"\n {dromas} г" +
                        $"\n {sahmas} г" +
                        $"\n {solmas} г" +
                        $"\n {milmas} г" +
                        $"\n {yaimas} г" +
                        $"\n {slimas} г" +
                        $"\n {rastmas} г" +
                        $"\n {kapmas} г");

                    richTextBox5.Text = ($"" +
                        $" {mykpacket1} мал.уп. | {mykpacket2} ср.уп. | {mykpacket3} бол. уп. | {mykpacket4} очень бол. уп." +
                        $"\n {dropacket1} мал.уп. | {dropacket2} бол. уп." +
                        $"\n {dropacket1} уп." +
                        $"\n {solpacket1} уп." +
                        $"\n {milpacket1} уп." +
                        $"\n {yaipacket1} мал.уп. | {yaipacket2} бол. уп." +
                        $"\n {slipacket1} мал.уп. | {slipacket2} бол. уп." +
                        $"\n {rastpacket1} уп." +
                        $"\n {kappacket1} шт.");

                    break;

                case "Мясо":

                    richTextBox1.Text = ($"" +
                        $" Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\n Сухие дрожжи - {droj} г" +
                        $"\n Сахар - {sahar} г" +
                        $"\n Соль - {soli} г" +
                        $"\n Молоко - {milk} мл." +
                        $"\n Яйцо - {yaizo} шт." +
                        $"\n Сливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\n Растительное масло (для замеса теста) - {rastmaslo} мл" +
                        $"\n Мясо - {myaso} гр");

                    richTextBox2.Text = ($"" +
                        $" {myk.name}" +
                        $"\n {dro.name}" +
                        $"\n {sah.name}" +
                        $"\n {sol.name}" +
                        $"\n {mil.name}" +
                        $"\n {yai.name}" +
                        $"\n {sli.name}" +
                        $"\n {rast.name}" +
                        $"\n {mya.name}");

                    richTextBox3.Text = ($"" +
                        $" {mykasto} руб" +
                        $"\n {drosto} руб" +
                        $"\n {sahsto} руб" +
                        $"\n {solsto} руб" +
                        $"\n {milsto} руб" +
                        $"\n {yaisto} руб" +
                        $"\n {slisto} руб" +
                        $"\n {raststo} руб" +
                        $"\n {myasto} руб");

                    richTextBox4.Text = ($"" +
                        $" {mykamas} г" +
                        $"\n {dromas} г" +
                        $"\n {sahmas} г" +
                        $"\n {solmas} г" +
                        $"\n {milmas} г" +
                        $"\n {yaimas} г" +
                        $"\n {slimas} г" +
                        $"\n {rastmas} г" +
                        $"\n {myamas} г");

                    richTextBox5.Text = ($"" +
                        $" {mykpacket1} мал.уп. | {mykpacket2} ср.уп. | {mykpacket3} бол. уп. | {mykpacket4} очень бол. уп." +
                        $"\n {dropacket1} мал.уп. | {dropacket2} бол. уп." +
                        $"\n {dropacket1} уп." +
                        $"\n {solpacket1} уп." +
                        $"\n {milpacket1} уп." +
                        $"\n {yaipacket1} мал.уп. | {yaipacket2} бол. уп." +
                        $"\n {slipacket1} мал.уп. | {slipacket2} бол. уп." +
                        $"\n {rastpacket1} уп." +
                        $"\n {myapacket1} уп.");

                    break;

                case "Повидло":

                    richTextBox1.Text = ($"" +
                        $" Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\n Сухие дрожжи - {droj} г" +
                        $"\n Сахар - {sahar} г" +
                        $"\n Соль - {soli} г" +
                        $"\n Молоко - {milk} мл." +
                        $"\n Яйцо - {yaizo} шт." +
                        $"\n Сливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\n Растительное масло (для замеса теста) - {rastmaslo} мл" +
                        $"\n Повидло - {povidlo} мл");

                    richTextBox2.Text = ($"" +
                        $" {myk.name}" +
                        $"\n {dro.name}" +
                        $"\n {sah.name}" +
                        $"\n {sol.name}" +
                        $"\n {mil.name}" +
                        $"\n {yai.name}" +
                        $"\n {sli.name}" +
                        $"\n {rast.name}" +
                        $"\n {pov.name}");

                    richTextBox3.Text = ($"" +
                        $" {mykasto} руб" +
                        $"\n {drosto} руб" +
                        $"\n {sahsto} руб" +
                        $"\n {solsto} руб" +
                        $"\n {milsto} руб" +
                        $"\n {yaisto} руб" +
                        $"\n {slisto} руб" +
                        $"\n {raststo} руб" +
                        $"\n {povsto} руб");

                    richTextBox4.Text = ($"" +
                        $" {mykamas} г" +
                        $"\n {dromas} г" +
                        $"\n {sahmas} г" +
                        $"\n {solmas} г" +
                        $"\n {milmas} г" +
                        $"\n {yaimas} г" +
                        $"\n {slimas} г" +
                        $"\n {rastmas} г" +
                        $"\n {povmas} г");

                    richTextBox5.Text = ($"" +
                        $" {mykpacket1} мал.уп. | {mykpacket2} ср.уп. | {mykpacket3} бол. уп. | {mykpacket4} очень бол. уп." +
                        $"\n {dropacket1} мал.уп. | {dropacket2} бол. уп." +
                        $"\n {dropacket1} уп." +
                        $"\n {solpacket1} уп." +
                        $"\n {milpacket1} уп." +
                        $"\n {yaipacket1} мал.уп. | {yaipacket2} бол. уп." +
                        $"\n {slipacket1} мал.уп. | {slipacket2} бол. уп." +
                        $"\n {rastpacket1} уп." +
                        $"\n {povpacket1} уп.");

                    break;

                case "Лук и Яйцо":

                    richTextBox1.Text = ($"" +
                        $" Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\n Сухие дрожжи - {droj} г" +
                        $"\n Сахар - {sahar} г" +
                        $"\n Соль - {soli} г" +
                        $"\n Молоко - {milk} мл." +
                        $"\n Яйцо - {yaizo} шт." +
                        $"\n Сливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\n Растительное масло (для замеса теста) - {rastmaslo} мл" +
                        $"\n Лук - {lyk} гр");

                    richTextBox2.Text = ($"" +
                        $" {myk.name}" +
                        $"\n {dro.name}" +
                        $"\n {sah.name}" +
                        $"\n {sol.name}" +
                        $"\n {mil.name}" +
                        $"\n {yai.name}" +
                        $"\n {sli.name}" +
                        $"\n {rast.name}" +
                        $"\n {ly.name}");

                    richTextBox3.Text = ($"" +
                        $" {mykasto} руб" +
                        $"\n {drosto} руб" +
                        $"\n {sahsto} руб" +
                        $"\n {solsto} руб" +
                        $"\n {milsto} руб" +
                        $"\n {yaisto} руб" +
                        $"\n {slisto} руб" +
                        $"\n {raststo} руб" +
                        $"\n {lyksto} руб");

                    richTextBox4.Text = ($"" +
                        $" {mykamas} г" +
                        $"\n {dromas} г" +
                        $"\n {sahmas} г" +
                        $"\n {solmas} г" +
                        $"\n {milmas} г" +
                        $"\n {yaimas} г" +
                        $"\n {slimas} г" +
                        $"\n {rastmas} г" +
                        $"\n {lykmas} г");

                    richTextBox5.Text = ($"" +
                        $" {mykpacket1} мал.уп. | {mykpacket2} ср.уп. | {mykpacket3} бол. уп. | {mykpacket4} очень бол. уп." +
                        $"\n {dropacket1} мал.уп. | {dropacket2} бол. уп." +
                        $"\n {dropacket1} уп." +
                        $"\n {solpacket1} уп." +
                        $"\n {milpacket1} уп." +
                        $"\n {yaipacket1} мал.уп. | {yaipacket2} бол. уп." +
                        $"\n {slipacket1} мал.уп. | {slipacket2} бол. уп." +
                        $"\n {rastpacket1} уп." +
                        $"\n {lykpacket1} уп.");

                    break;

                case "Картофель":

                    richTextBox1.Text = ($"" +
                        $"Мука - {myka} г.(у вас может уйти чуть больше или меньше)" +
                        $"\nСухие дрожжи - {droj} г" +
                        $"\nСахар - {sahar} г" +
                        $"\nСоль - {soli} г" +
                        $"\nМолоко - {milk} мл." +
                        $"\nЯйцо - {yaizo} шт." +
                        $"\nСливочное масло - {slivmaslo} г. (можно заменить растительным)" +
                        $"\nРастительное масло (для замеса теста) - {rastmaslo} мл" +
                        $"\nКартофель - {potato} гр");

                    richTextBox2.Text = ($"" +
                        $" {myk.name}" +
                        $"\n {dro.name}" +
                        $"\n {sah.name}" +
                        $"\n {sol.name}" +
                        $"\n {mil.name}" +
                        $"\n {yai.name}" +
                        $"\n {sli.name}" +
                        $"\n {rast.name}" +
                        $"\n {pot.name}");

                    richTextBox3.Text = ($"" +
                        $" {mykasto} руб" +
                        $"\n {drosto} руб" +
                        $"\n {sahsto} руб" +
                        $"\n {solsto} руб" +
                        $"\n {milsto} руб" +
                        $"\n {yaisto} руб" +
                        $"\n {slisto} руб" +
                        $"\n {raststo} руб" +
                        $"\n {potsto} руб");

                    richTextBox4.Text = ($"" +
                        $" {mykamas} г" +
                        $"\n {dromas} г" +
                        $"\n {sahmas} г" +
                        $"\n {solmas} г" +
                        $"\n {milmas} г" +
                        $"\n {yaimas} г" +
                        $"\n {slimas} г" +
                        $"\n {rastmas} г" +
                        $"\n {potmas} г");

                    richTextBox5.Text = ($"" +
                        $" {mykpacket1} мал.уп. | {mykpacket2} ср.уп. | {mykpacket3} бол. уп. | {mykpacket4} очень бол. уп." +
                        $"\n {dropacket1} мал.уп. | {dropacket2} бол. уп." +
                        $"\n {dropacket1} уп." +
                        $"\n {solpacket1} уп." +
                        $"\n {milpacket1} уп." +
                        $"\n {yaipacket1} мал.уп. | {yaipacket2} бол. уп." +
                        $"\n {slipacket1} мал.уп. | {slipacket2} бол. уп." +
                        $"\n {rastpacket1} уп." +
                        $"\n {potpacket1} уп.");

                    break;
            }


        }
    }
}
