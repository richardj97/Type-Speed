using System;
using System.Collections.Generic;
using System.Linq;

namespace Tpying_Race
{
    class Generate
    {
        private List<Paragraph> ListPara;
        private int selectedPara;

        public string GetData()
        {
            return ListPara[selectedPara].Text;
        }
        public string GetTitle()
        {
            return ListPara[selectedPara].Title;
        }
        public Generate()
        {
            ListPara = new List<Paragraph>();

            /* Paragraphs credit to: http://www.preservearticles.com/2012041930718/33-very-short-paragraphs-for-kids.html */
            /* Another way to import paragraphs is by using Stream Reader via .txt files */

            Paragraph p = new Paragraph("Each One Teach One", "Adult education is essential for Democracy of India. The number of grown up illiterates is great. All college and senior School students should come forward to visit villages in the summer vacation. Each one will teach one there. This will remove illiteracy and strengthen our democracy.");
            Paragraph p2 = new Paragraph("The Stampede at Wankhade Stadium", "I happened to see a one day cricket match between Pakistan and Australia at Wankhade Stadium, Mumbai. I went for a fun. But I wit­nessed a horrible sight. Two thousand ticketless cricket fans gate crashed. There was a stampede. Three persons died and twenty were injured. Administration was responsible for it.");
            Paragraph p3 = new Paragraph("Anti Pollution Drive", "City Anti-pollution Drive demands certain steps from all the people of ABC city. All house-holders should pack the waste in a plastic bag and put the bag in front of their house. The bag will be replaced with an empty bag by the Municipal van every morning. They should maintain the cleanliness of the city. This will make the city pollution free.");
            Paragraph p4 = new Paragraph("A Slum Area after the Rainy Season", "My visit to a slum area after the rainy season was a sad affair. The pits were still full of rain water. There was mud all around. The polluted water had caused various diseases. There was no home without a sick person. Small children suffered from stomach troubles. The govern­ment should immediately rush to the help of the sufferers in the slum area.");
            Paragraph p5 = new Paragraph("Catching a Thief", "I saw a man climbing down a water pipe. He had a knife in his hand. I hit his hand with a brick. He fell down on the ground and I jumped upon him. Soon others reached there and we handed him over to the police.");
            Paragraph p6 = new Paragraph("Memories of Childhood", "Memories of childhood are unforgettable. I was four years old when my grandfather died. I clearly remember how everybody in the house was weeping. Once my mother loved me very much when I had a bad dream. I broke my leg and was in a plaster for two months. These and other memories still come on the inner screen of my mind very often.");
            Paragraph p7 = new Paragraph("A Drowning Tragedy", "A tragedy took place yesterday when a Matador fell into a canal. The driver of the Matador tried to save an auto-rickshaw and lost con­trol on the vehicle. About fifty students were travelling in it. The people from the nearby villages saved twenty-seven students. The dead bod­ies of the drowned were recovered. It was a very painful sight.");
            Paragraph p8 = new Paragraph("Joys of City Life", "City life is full of fun. There are parks and picnic spots to visit. We have cinema halls to see movies. We have electricity which runs our factories, light and cools our home and helps us in seeing T.V. There are all type of amenities like water, health check up and transport. Sometimes circus shows and magic shows entertain the city people.");
            Paragraph p9 = new Paragraph("Bomb Blast in a Train", "I was lucky to escape death by a few seconds. A bomb blasted in the compartment of Nilanchal Express. The overcrowded compartment made me to get down. Anyhow the loss was great. About ten people died and many got injured. It was the job of a terrorist. The government should intensify searching operations in trains.");
            Paragraph p10 = new Paragraph("Green Your City Drive", "Your city has everything but trees. The trees are essential for clean environment. Thus clean environment needs green environment. Each person should plant a tree in the empty space before his house. He should look after it and let it grow up. The greenness will make your city worth living.");
            Paragraph p11 = new Paragraph("Report about a Circus Show", "The Gemini Circus had added many new items to attract crowd. The usual feats of rope-walking, cycling, horse tricks were heartwarming. The lion giving ride to human child was the best of all the items. The elephant came with a tiger on its back. A jeep had a ten meter jump. The band added, charm to the whole show.");
            Paragraph p12 = new Paragraph("Railway Cleanliness Drive", "Indian railways have started Cleanliness Drive with great zeal. The Railway Minister was the first to hold the broom. Others followed. The aim was to clean platforms, clean waiting rooms and clean toilets. Dustbins have been placed at different spots. The passengers are en­couraged to use these dustbins more and more. The cleanliness drive will surely leave its mark on the people.");
            Paragraph p13 = new Paragraph("Inauguration Ceremony of the World Trade Fair", "The inauguration of the World Trade Fair 2012 was a great affair. It was inaugurated by the President of India. Many ministers attended the function. Almost all the countries displayed their latest items of trade for the Indian market. Thus a large gathering of Indian and foreign busi­nessmen took part in the proceedings.");
            Paragraph p14 = new Paragraph("Pleasures of Reading", "Reading is a blessing for men and women. The habit of reading introduces us to great masters and great minds. It enables us to pass our time usefully. We avoid bad company and live in a separate world of books. Reading kills boredom in youth and old age.");
            Paragraph p15 = new Paragraph("The Limitations of Village Life", "The village life offers many pleasures. But it has its own limitations too. There are no big hospitals in the village. Good drinking water is scarce these days. Transport is a problem for villagers. Facilities of education are fewer. There are shortages of many necessary things needed in our daily life.");
            Paragraph p16 = new Paragraph("The Stampede at Haridwar", "Haridwar is a sacred place of the Hindus. People often go there for a dip in ganga. This year lacs of peoples gathered for enjoying Purnima bath. People began to enjoy dips very early. But somehow, rush in ased on one of the bridges. People began to rush and there was a stampede. About eighty five people lost their lives. The authorities realized the mistake afterwards but it was too late.");
            Paragraph p17 = new Paragraph("The First Rainy Day", "It was 9th of July, I left for my office. I had not gone far when it began to rain heavily Soon the roads began to overflow. The traffic got jammed. I went from one road to another to get a clear passage to my office.But to my ill luck, I found the traffic jammed on every road. I found some buses deserted in deep waters.I could reach my office only after three hours of great labour.");
            Paragraph p18 = new Paragraph("The Fruit I Like", "I eat every fruit. Fruit is good for health. But I like apple most. Apples have many point to score over other fruits. It is tasty. It is juicy. It has more iron. It has more vitamins. It is easily digestible. We can eat this fruit before or after meal. Kashmiri apples are the best to eat.");
            Paragraph p19 = new Paragraph("Advantages of Morning Walk", "Morning walk has many advantages. Air is cool and fresh in the morning. Those who go for morning walk can breathe in the fresh air. They refresh their mind and body. They lose their tension. Their heart becomes stronger. They walk more. They remain happly all the day.");
            Paragraph p20 = new Paragraph("A Pleasant Dream", "I had a pleasant dream last night. I saw my friend in my dream. He had a newspaper in his hand. He showed me my result. There was a merit list. My name was at the top. I was very happy. And in happiness I was awakened by my mother. She had a newspaper in her hand. The newspaper still showed me on top.");
            Paragraph p21 = new Paragraph("Problem of Unemployment", "Unemployment is a burning problem of India today. Our schools and Universities produces more job-seeking men than the jobs avail­able. The young men only want office jobs. They do not get proficiency in some technical line. The result is that our young men roam about on the roads. The incidents of thefts and other unsocial acts are due to unemployment.");
            Paragraph p22 = new Paragraph("Strikes", "Strikes means not to go for work. It is a weapon of the weak against the strong. The workers often resorts to strikes to highlight their de­mands. Strikes are not bad but their method is bad. Worker should not go on strikes for longer periods. They should strike work for a few minutes daily to press their demands. Let the production not suffer.");
            Paragraph p23 = new Paragraph("Value of Trees", "Trees are very valuable. They give us shade for the rest. They give shelter to birds and animals. They give us wood to burn. They supply us many necessary things of everyday life They take carbon dioxide from the atmosphere and fill it with oxygen. They cause rains. They check soil erosion. They also check floods. In short the trees are the best friends of man.");
            Paragraph p24 = new Paragraph("Smoking", "Smoking is very injurious to health. It is harmful both to a smoker and his companion. It affects lungs and causes serious diseases. One of the chief causes of ailment is smoking. It pollutes the environment too. Government should take steps to fine the people smoking at public places.");
            Paragraph p25 = new Paragraph("Punctuality", "Punctuality means time-sense. To fulfil your assignments on time is punctuality. It is the ornament of a gentleman and a weapon in the hands of a boss. Those who are punctual are loved and liked by all. They finish their job in time and are able to give finishing touches needed for the job They never miss golden chances and are always success­ful in life.");
            Paragraph p26 = new Paragraph("Population Problem", "Population problem is a major problem of India. There is no in­crease in our resources. But there is a regular increase in our popula­tion. Our roads have more traffic. There are more men on the same land. We will have to make more schools, more hospitals and more essential things for the growing population. If we do not check this prob­lem, poverty will soon overtake us.");
            Paragraph p27 = new Paragraph("Pollution", "Population means imbalance in atmosphere. Air gets polluted with the smoke from homes, factories and vehicles. Water gets polluted with city and factory wastes. Loud noise is causing sound pollution. Dilution in fact, spreads diseases and makes life hell on earth.");
            Paragraph p28 = new Paragraph("Water Pollution", "Water Pollution is the worst form of pollution. Our water gets polluted when city refuge mingles with river water. The factories drain their chemicals into nearby river. The drinking water has become a problem. There is a danger to animal life in water. Many species of fish have perished. The sooner the pollution is checked the better.");
            Paragraph p29 = new Paragraph("Noise Pollution", "Pollution is the burning problem of today. But not much attention is paid to noise pollution. The noise from vehicles, machines and loud­speakers is deafening. People have to speak loudly to be heard. All this causes tension and lot of diseases. Government should take steps to control noise pollution.");
            Paragraph p30 = new Paragraph("A Visit to a Science Fair", "My Visit to a Science Fair In D.A.V. Senior Secondary School, Shalimar Bagh was a happy experience. There were 160 exhibits on display. These model inventions showed the progress of Science in our Schools. The young scientists were explaining their inventions with pride. The best exhibit was a robot that served us tea. The fair showed the future greatness of our country.");
            Paragraph p31 = new Paragraph("Rising Prices", "Rising prices have made the life of common man very difficult. He cannot make both ends means. The hoarders are chiefly responsible for the rising prices. The greedy traders raise prices to get more profit. The Government should help the people. It should distribute essential commodities at fair price shops. It should also take steps to check hoarding.");
            Paragraph p32 = new Paragraph("Evils of Dowry System", "Dowry consists of things given by parents to their daughters at the time of their marriage. Once this was done to start life well. But the greedy parents of bridegrooms demand more money and material. Some girls have to lose their lives for bringing fewer dowries. Burning brides is daily news these days. Both the, Government and the public should discourage the dowry seekers.");
            Paragraph p33 = new Paragraph("Evils of Drinking", "Drinking stands for drinking of alcohol. There are many evils of drinking. It spoils once health. It affects lungs and other organs of the body. The drunkards drink much and waste their money. They cannot run their families properly. They destroy the live of their family mem­bers. In some cases they also become scoundrels.");

            ListPara.Add(p);
            ListPara.Add(p2);
            ListPara.Add(p3);
            ListPara.Add(p4);
            ListPara.Add(p5);
            ListPara.Add(p6);
            ListPara.Add(p7);
            ListPara.Add(p8);
            ListPara.Add(p9);
            ListPara.Add(p10);
            ListPara.Add(p11);
            ListPara.Add(p12);
            ListPara.Add(p13);
            ListPara.Add(p14);
            ListPara.Add(p15);
            ListPara.Add(p16);
            ListPara.Add(p17);
            ListPara.Add(p18);
            ListPara.Add(p19);
            ListPara.Add(p20);
            ListPara.Add(p21);
            ListPara.Add(p22);
            ListPara.Add(p23);
            ListPara.Add(p24);
            ListPara.Add(p25);
            ListPara.Add(p26);
            ListPara.Add(p27);
            ListPara.Add(p28);
            ListPara.Add(p29);
            ListPara.Add(p30);
            ListPara.Add(p31);
            ListPara.Add(p32);
            ListPara.Add(p33);

            Random rnd = new Random();
            selectedPara = rnd.Next(0, ListPara.Count());
        }
    }
}
