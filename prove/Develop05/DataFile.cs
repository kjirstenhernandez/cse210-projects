public class DataFile{
    GoalManager goalManager = new GoalManager();
    List<string> goals = new List<string>();

    public void ImportGoals(string goal){        
        goals.Add(goal);
    }


    public void SaveFile(string filename){
        using (StreamWriter saveFile = new StreamWriter(filename)){
            int score = goalManager.GetScore();
            saveFile.WriteLine(score);
            string animal = goalManager.GetAnimal();
            saveFile.WriteLine(animal);
            goals.ForEach(line => saveFile.WriteLine(line));
        }
    }

    public List<string> LoadFile(string filename){
        
        //  Lines 24-28 didn't work when I was trying to use StreamWriter, it kept giving me
        //  an error saying 'StreamWriter does not contain a definition for ReadLine'.  The identical
        //  lines work fine with StreamReader, so I'm not terribly worried about it, but is there something
        //  I should've done differently with StreamWriter instead?
        using (StreamReader loadFile = new StreamReader(filename)){
            
            string scoreString = loadFile.ReadLine();
            int score = int.Parse(scoreString);
            goalManager.ResetScore(score);

            string animalString = loadFile.ReadLine();
            goalManager.ResetAnimal(animalString);
            
            string text = loadFile.ReadToEnd();
            string[] lines = text.Split(Environment.NewLine);
            foreach (string item in lines){
                if (item != ""){
                    goals.Add(item);
                }
            }
        }
    return goals;
    }
}