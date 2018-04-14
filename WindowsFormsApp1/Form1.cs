using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvConverter;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String pathFile = @"C:\Users\Paweł\Downloads\PrestaShop 0.csv";
        public Form1()
        {
            InitializeComponent();
            //Row row = new Row("0;1;COLWAY Kolagen Naturalny PLATINUM 50ml, do twarzy szyi dekoltu, skóry wrazliwej;446,513,514;224,73;COLWAY;5907441036061;100;Kolagen jest „proteiną młodości”, która stanowi ponad 30% masy białka ludzkiego i aż 70% białek skóry.<br>Kolagen wraz z elastyną tworzą w skórze właściwej elastyczną siateczkę, która nadaje jej sprężystość i jędrność, a także wiąże wodę, substancje lipofilowe i stanowi o kondycji tkanki łącznej czyli w istocie o kondycji całego organizmu.<br>To kolagen stanowi najwierniejsze odzwierciedlenie potencjału biologicznego ciała, dlatego tak ważne jest zachowanie jego jak najlepszej struktury.Od około 25 roku życia spowalnia produkcja i obrót kolagenu, a nasza skóra zaczyna tracić elastyczność i sprężystość, podobnie jak nasze mięśnie tracą siłę, a kości wapń.<br>Są to pierwsze objawy deficytu kolagenu, którego biosynteza z upływem czasu jest coraz słabsza.Kolagen Naturalny Platinum polecany jest do pielęgnacji twarzy i dekoltu oraz do delikatnych partii ciała.<br>Wspomaga zabiegi rewitalizujące cerę dojrzałą, nieinwazyjnie daje efekt lifting twarzy i regeneruje skórę po zabiegach chirurgii plastycznej.<br>Regularne stosowanie zatrzymuje procesy starzenia się skóry.KOLAGEN NATURALNY<br>• to nieinwazyjny preparat zawierający  100% naturalnego białka - Hydrat tropokolagenu -ekologiczny w 100%!<br>• przez aplikację, dostarczamy skórze z zewnątrz tego, czego zaczyna brakować wewnątrz.<br><br>• nie uczula ani nie podrażnia skóry<br>• nie powoduje żadnych działań ubocznych<br>• nie zawiera sztucznych barwników , aromatów, środków zapachowychSkład: woda, kolagen rybi, glikol kaprylowy, elastyna, kwas mlekowy.Z racji, że nie zawiera żadnych aromatów, barwników, ani konserwantów.<br>Dla wielu osób uczulonych na składniki chemiczne stosowane w kosmetykach stanowi jedyną skuteczną alternatywę dla ochrony skóry przed nieubłaganym procesem starzenia.KOLAGEN NATURALNY JEST BIAŁKIEM ŻYWYM.<br>JEST REWOLUCJĄ!Kolagen Naturalny to łańcuch 1000 aminokwasów związanych w spirale i wytwarzanych w cyklu metabolicznym tylko przez kręgowce.<br>Pozyskiwany jest z ekstraktu skór ryb najszlachetniejszych gatunków, odławianych z naturalnych zbiorników i filtrowany fibroinami osnowy jedwabnika morwowego.<br>Kolagen pozyskiwany w ten sposób zachowuje budowę przestrzenną, bliźniaczo podobną do budowy kolagenu ludzkiego, tzw.<br>potrójną helisę.Stosowanie :Preparat nakłada się zawsze na oczyszczoną i mokrą skórę.<br>Wskazane jest także wcześniejsze zastosowanie odpowiedniego peelingu (raz, dwa razy w tygodniu).<br>Na tak przygotowaną i wilgotną jeszcze skórę nakładamy żel bardzo cienką warstwą i delikatnie wklepujemy/wmasowujemy opuszkami palców, ruchami zgodnymi z układem mięśni.<br>W razie uczucia lepkości należy zwilżyć palce wodą i kontynuować rozprowadzanie wieńcząc je wklepywaniem.<br>Końcowy efekt ma dać efekt, jakby na skórę nic nie było nakładane.<br>Kolagen Naturalny podczas aplikacji może czasowo dać poczucie ciepła na skórze, jest to chwilowe i całkowicie bezpieczne.Wchłania się około 7 minut do skóry właściwej, proces ten jest zakończony po 15-30 minutach.Kolageny Naturalne COLWAY wytwarzane są unikalnym, polskim sposobem pozyskiwania kolagenu ze skór rybich, na który Urząd Patentowy Rzeczypospolitej Polskiej udzielił tylko jednego prawa ochronnego nr 206813.<br>Numer tego patentu umieszczony na każdym opakowaniu odróżnia produkty COLWAY od innych, tańszych „kolagenów” , jakie mogą pojawiać się na rynku.<br>;Pojemność: 50ml;http://serwer1441360.home.pl/web/colway_foto/platinum_50_box.png,http://serwer1441360.home.pl/web/colway_foto/platinum_zestaw.png;53");
            //label1.Text = row.print();
            ReadCsvFile readCsvFile = new ReadCsvFile(pathFile);
            readCsvFile.readfile();
            label1.Text = readCsvFile.getRow(30).print();
        }
    }
}
