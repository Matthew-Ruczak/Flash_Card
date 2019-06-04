using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Flash_Card
{
    class ReadAndWriteToFile
    {
        //Reads a given file path, and then returns the content as a 'ListOfCards'
        public static ListOfCards readFromFile(string fileName)
        {
            //Reading from the file the user selected using a stream
            using (StreamReader r = new StreamReader(fileName))
            {
                //Reading file into a string
                string json = r.ReadToEnd();
                //Converting the json string into a 'Card' object (Using the below card class)
                List<tmpCard> tmpListOfCards = JsonConvert.DeserializeObject<List<tmpCard>>(json);

                //Creating a instance of ListOfCards, so we can return it once the cards have been put in
                ListOfCards returnListOfCards = new ListOfCards();  

                //Putting the 'Cards' from the 'tmpListOfCards' into the 'listOfCards' (Covering from a tmpCard to a Card, foreach element)
                foreach (tmpCard c in tmpListOfCards)
                {
                    returnListOfCards.addCard(new Card(c.question, c.answer));
                }

                //Returning the 'ListOfCard' that was read from the file
                return returnListOfCards;
            }
        }

        public static bool writeToFile(string fileName, ListOfCards content)
        {
            try
            {
                //Putting the cards in 'content' into a List<tmpCard> for processing
                List<tmpCard> tmpListOfCards = new List<tmpCard>();

                for (int x = 0; x <= (content.getNumOfCards() - 1); x++)
                {
                    tmpListOfCards.Add(new tmpCard()
                    {
                        question = content.getCardAt(x).getQuestion(),
                        answer = content.getCardAt(x).getAnswer()
                    });
                }
                //Converting 'tmpListOfCards' into JSON
                string json = JsonConvert.SerializeObject(tmpListOfCards.ToArray());

                //Writing to the file 'json'
                System.IO.File.WriteAllText(fileName,json);

                return true;    //Writing to the file was successful
            }   
            catch
            {
                return false;   //Writing to file failed
            }
        }
    }

    //This Class is used when deserializing the json object (so we do not have the change the 'Card' class
    public class tmpCard
    {
        public string question;
        public string answer;
    }
}
