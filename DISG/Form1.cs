using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DISG
{
    public partial class Form1 : Form
    {
        public class Frage
        {
            public int nr;
            public String frage;
            public char ergebnis;
            public Frage(int i, String s, char c)
            {
                nr = i;
                frage = s;
                ergebnis = c;
            }
        }
        Frage[] fragen1 = {             
new Frage(1,"ich teile gern",'S'),
new Frage(1,"ich bin umgänglich",'N'),
new Frage(1,"ich will gewinnen",'D'),
new Frage(1,"ich lache viel",'N'),
new Frage(2,"ich bin offen für Ideen",'I'),
new Frage(2,"ich tue anderen gerne einen Gefallen",'G'),
new Frage(2,"ich bin willensstark",'N'),
new Frage(2,"ich bin fröhlich und sorglos",'S'),
new Frage(3,"ich neige dazu zu machen, was andere wollen",'N'),
new Frage(3,"ich mache, was ich will",'D'),
new Frage(3,"ich erreiche durch Freundlichkeit mein Ziel",'I'),
new Frage(3,"ich bin anderen gegenüber aufrichtig",'S'),
new Frage(4,"bei anderen bin ich beliebt",'I'),
new Frage(4,"ich bin selbstbeherrscht",'G'),
new Frage(4,"ich bin kollegial und freundlich",'S'),
new Frage(4,"ich bin rastlos",'D'),
new Frage(5,"mich zufrieden zu stellen fällt schwer",'N'),
new Frage(5,"ich will andere übertrumpfen",'D'),
new Frage(5,"ich halte mich an Regeln",'S'),
new Frage(5,"ich bin immer für einen Scherz zu haben",'I'),
new Frage(6,"ich gehe Risiken ein",'D'),
new Frage(6,"ich bin taktvoll",'G'),
new Frage(6,"ich bin anmutig",'N'),
new Frage(6,"ich bin zufrieden",'S'),
new Frage(7,"ich bin begeisterungsfähig",'N'),
new Frage(7,"ich bin korrekt und genau",'G'),
new Frage(7,"ich bin ausgeglichen",'S'),
new Frage(7,"ich übernehme gern die Initiative",'N'),
new Frage(8,"ich trete bestimmt auf",'D'),
new Frage(8,"ich stehe gerne im Mittelpunkt",'I'),
new Frage(8,"ich neige dazu, Schwierigkeiten zu erwarten",'N'),
new Frage(8,"ich bin leicht zu beeinflussen",'S'),
new Frage(9,"ich bekomme viel Lob",'N'),
new Frage(9,"ich bin hilfsbereit",'S'),
new Frage(9,"ich setze mich für meine Prinzipien ein",'D'),
new Frage(9,"ich habe keine Probleme mich unterzuordnen",'N'),
new Frage(10,"ich bin ungeduldig",'D'),
new Frage(10,"ich komme gut mit anderen aus",'G'),
new Frage(10,"ich möchte es anderen recht machen",'S'),
new Frage(10,"ich bin temperamentvoll",'N'),
new Frage(11,"ich bin kontaktfreudig",'I'),
new Frage(11,"ich bin ein Mensch der Tat",'D'),
new Frage(11,"ich bin weichherzig",'S'),
new Frage(11,"ich habe Sinn für schöne Dinge",'N'),
new Frage(12,"ich neige nicht dazu, die Dinge allzu eng zu sehen",'N'),
new Frage(12,"ich bin lebenslustig",'I'),
new Frage(12,"ich gehe keinem Streit aus dem Weg",'D'),
new Frage(12,"ich bin diplomatisch",'G'),
new Frage(13,"es fällt mir leicht Entscheidungen zu treffen",'D'),
new Frage(13,"ich bin spontan",'I'),
new Frage(13,"ich bin friedliebend",'G'),
new Frage(13,"ich bringe andere Vertrauen entgegen",'S'),
new Frage(14,"ich bin höflich und zuvorkommend",'G'),
new Frage(14,"ich bin abenteuerlustig",'D'),
new Frage(14,"ich blicke optimistisch in die Zukunft",'I'),
new Frage(14,"ich nehme Rücksicht auf andere",'S'),
new Frage(15,"mich in andere einzufühlen fällt mir leicht",'S'),
new Frage(15,"ich bin zurückhaltend",'G'),
new Frage(15,"ich kann andere leicht überzeugen",'I'),
new Frage(15,"ich habe viele Ideen",'N'),
new Frage(16,"ich bin gesprächig",'I'),
new Frage(16,"mich mit etwas abzufinden fällt mir nicht schwer",'S'),
new Frage(16,"ich hänge an meinen Gewohnheiten",'N'),
new Frage(16,"ich bin entscheidungsfreudig",'D'),
new Frage(17,"ich bin zögerlich",'G'),
new Frage(17,"Erfolg zu haben ist mir wichtig",'D'),
new Frage(17,"ich gehe freundlich mit anderen um",'S'),
new Frage(17,"ich kann andere beeinflussen",'I'),
new Frage(18,"ich kann andere mitreißen",'I'),
new Frage(18,"ich bleibe hartnäckig an einer Aufgabe",'D'),
new Frage(18,"ich bin neugierig",'G'),
new Frage(18,"ich achte auf Bedürfnisse anderer",'N'),
new Frage(19,"ich bin gesellig",'I'),
new Frage(19,"ich arbeite gern allein",'D'),
new Frage(19,"ich bin eher ein stiller Mensch",'G'),
new Frage(19,"mich bringt so leicht nichts aus der Ruhe",'S'),
new Frage(20,"ich bin diszipliniert",'G'),
new Frage(20,"ich bin aufgeschlossen und kontaktfreudig",'N'),
new Frage(20,"ich bin großzügig",'S'),
new Frage(20,"ich sage die Dinge, wie sie sind",'D'),
new Frage(21,"ich bin schüchtern",'N'),
new Frage(21,"ich bin entschlusskräftig",'D'),
new Frage(21,"andere zu begeistern fällt mir leicht",'I'),
new Frage(21,"ich gebe leicht nach",'N'),
new Frage(22,"andere um den Finger zu wickeln fällt mir leicht",'I'),
new Frage(22,"ich neige dazu, meine Meinung zurückzuhalten",'N'),
new Frage(22,"ich denke nach, bevor ich etwas sage",'G'),
new Frage(22,"ich spreche aus, was ich denke",'D'),
new Frage(23,"ich bin warmherzig",'N'),
new Frage(23,"ich mag keine Extreme",'S'),
new Frage(23,"ich bin offen für neue Aufgaben",'G'),
new Frage(23,"ich will etwas erleben",'D'),
new Frage(24,"meinen Willen durchzusetzen fällt mir leicht",'D'),
new Frage(24,"im Umgang mit anderen bin ich verständnisvoll",'N'),
new Frage(24,"anderen Menschen bringe ich Respekt entgegen",'N'),
new Frage(24,"ich bin selbstsicher",'I')

        };
        Frage[] fragen2 = {

new Frage(1,"wählerisch",'G'),
new Frage(1,"gehorsam",'N'),
new Frage(1,"fordernd",'D'),
new Frage(1,"verspielt",'I'),
new Frage(2,"gesellig",'I'),
new Frage(2,"selbstsicher",'D'),
new Frage(2,"geduldig",'S'),
new Frage(2,"ruhig",'G'),
new Frage(3,"attraktiv",'I'),
new Frage(3,"prinzipientreu",'G'),
new Frage(3,"unbeugsam",'D'),
new Frage(3,"nett",'S'),
new Frage(4,"diplomatisch",'N'),
new Frage(4,"zufrieden",'S'),
new Frage(4,"waghalsig",'D'),
new Frage(4,"gewandt",'I'),
new Frage(5,"rastlos",'D'),
new Frage(5,"kritisch",'G'),
new Frage(5,"beliebt",'I'),
new Frage(5,"freundlich",'S'),
new Frage(6,"unerschrocken",'N'),
new Frage(6,"inspirierend",'N'),
new Frage(6,"unterwürfig",'S'),
new Frage(6,"schüchtern",'G'),
new Frage(7,"sanftmütig",'S'),
new Frage(7,"überzeugend",'N'),
new Frage(7,"bescheiden",'G'),
new Frage(7,"originell",'D'),
new Frage(8,"arrogant",'N'),
new Frage(8,"nachgiebig",'S'),
new Frage(8,"einnehmend",'I'),
new Frage(8,"ängstlich",'G'),
new Frage(9,"umgänglich",'I'),
new Frage(9,"genau",'N'),
new Frage(9,"direkt",'D'),
new Frage(9,"verschlossen",'S'),
new Frage(10,"respektvoll",'N'),
new Frage(10,"risikobereit",'D'),
new Frage(10,"optimistisch",'I'),
new Frage(10,"zuvorkommend",'S'),
new Frage(11,"kühn",'D'),
new Frage(11,"beeinflussbar",'G'),
new Frage(11,"loyal",'N'),
new Frage(11,"charmant",'I'),
new Frage(12,"rücksichtsvoll",'S'),
new Frage(12,"ehrgeizig",'D'),
new Frage(12,"fröhlich",'I'),
new Frage(12,"ausgleichend",'G'),
new Frage(13,"mutig",'D'),
new Frage(13,"gelassen",'S'),
new Frage(13,"präzise",'G'),
new Frage(13,"glücklich",'I'),
new Frage(14,"streitlustig",'D'),
new Frage(14,"anpassungsfähig",'N'),
new Frage(14,"humorvoll",'I'),
new Frage(14,"locker",'S'),
new Frage(15,"lernwillig",'N'),
new Frage(15,"eifrig",'D'),
new Frage(15,"angenehm",'G'),
new Frage(15,"unbeschwert",'I'),
new Frage(16,"energisch",'D'),
new Frage(16,"anerkannt",'N'),
new Frage(16,"fürsorglich",'N'),
new Frage(16,"unsicher",'G'),
new Frage(17,"gesprächig",'I'),
new Frage(17,"zurückhaltend",'S'),
new Frage(17,"traditionsbewusst",'G'),
new Frage(17,"bestimmt",'D'),
new Frage(18,"souverän",'N'),
new Frage(18,"verständnisvoll",'S'),
new Frage(18,"tolerant",'G'),
new Frage(18,"durchsetzungsfähig",'D'),
new Frage(19,"großzügig",'S'),
new Frage(19,"lebhaft",'I'),
new Frage(19,"ordentlich",'N'),
new Frage(19,"hartnäckig",'D'),
new Frage(20,"vertrauensvoll",'I'),
new Frage(20,"ermutigend",'S'),
new Frage(20,"positiv",'N'),
new Frage(20,"friedliebend",'G'),
new Frage(21,"vorsichtig",'G'),
new Frage(21,"tatkräftig",'N'),
new Frage(21,"mitreißend",'I'),
new Frage(21,"gutmütig",'N'),
new Frage(22,"spontan",'N'),
new Frage(22,"entgegenkommend",'G'),
new Frage(22,"willensstark",'D'),
new Frage(22,"heiter",'S'),
new Frage(23,"abenteuerlustig",'D'),
new Frage(23,"aufgeschlossen",'N'),
new Frage(23,"sympathisch",'I'),
new Frage(23,"vernünftig",'S'),
new Frage(24,"kommunikativ",'I'),
new Frage(24,"kultiviert",'G'),
new Frage(24,"stark",'D'),
new Frage(24,"nachsichtig",'S')
        };
        
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        int frage;
        Frage[] liste = null;
        int disgD;
        int disgI;
        int disgS;
        int disgG;
        private void Start()
        {
            frage = 1;
            liste = fragen1;
            anweisung.Text = "Bitte wählen Sie was AM EHESTEN auf Sie zutrifft";
            setFrage();
            disgD=0;
            disgI=0;
            disgS=0;
            disgG=0;
        }
        private void setFrage()
        {
            int j = 1;
            for (int i = 0; i<liste.Length; i++)
            {
                if ( liste[i].nr == frage )
                {
                    switch (j)
                    {
                        case 1: 
                            radioButton1.Text = liste[i].frage;
                            radioButton1.Tag = liste[i].ergebnis;
                            break;
                            case 2: 
                            radioButton2.Text = liste[i].frage;
                            radioButton2.Tag = liste[i].ergebnis;
                            break;
                            case 3: 
                            radioButton3.Text = liste[i].frage;
                            radioButton3.Tag = liste[i].ergebnis;
                            break;
                            case 4: 
                            radioButton4.Text = liste[i].frage;
                            radioButton4.Tag = liste[i].ergebnis;
                            break;
                    }
                    j++;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton rb = null;
            if (radioButton1.Checked) rb = radioButton1;
            if (radioButton2.Checked) rb = radioButton2;
            if (radioButton3.Checked) rb = radioButton3;
            if (radioButton4.Checked) rb = radioButton4;
            if (rb == null)
            {
                MessageBox.Show("Sie müssen einen Punkt auswählen!");
            }
            else
            {
                String s = rb.Tag.ToString();
                switch (s[0])
                {
                    case 'D':
                        disgD++;
                        break;
                    case 'I':
                        disgI++;
                        break;
                    case 'S':
                        disgS++;
                        break;
                    case 'G':
                        disgG++;
                        break;
                }
                rb.Checked = false;
                frage++;
                if (frage == 25)
                {
                    if (liste == fragen1)
                    {
                        liste = fragen2;
                        MessageBox.Show("Ergebnis AM EHESTEN:\nD=" + disgD + " I=" + disgI + " S=" + disgS + " G=" + disgG+"\n(Bitte notieren)");
                        disgD = 0;
                        disgI = 0;
                        disgS = 0;
                        disgG = 0;
                        frage = 1;
                        anweisung.Text = "Bitte wählen Sie was AM WENIGSTEN auf Sie zutrifft.";
                        setFrage();
                    }
                    else
                    {
                        // Ergebnis zeigen
                        MessageBox.Show("Ergebnis AM WENIGSTEN:\nD=" + disgD + " I=" + disgI + " S=" + disgS + " G=" + disgG+"\n(Bitte notieren)");
                        Start();
                    }
                }
                else
                    setFrage();
            }
        }
    }
}