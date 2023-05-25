public class Scripture {

    private List<string> _scriptureWords = new List<string>();
    
    private string _scriptureReference;

    private string _hiddenWord;
    private string _compiledWords;
   
    public Scripture(string reference, string verse){
        // Constructor takes the verse and splits it into an array with the individual words 
        _scriptureReference = reference;
        string[] _wordsList = verse.Split(" ");
        foreach (string word in _wordsList){
            _scriptureWords.Add(word);
        }
    }
    
    public void HideWords(){
    // Randomly selects 3 words from _scriptureWords and replaces it with underscores
    // --> Creativity: Doesn't repeat words already hidden.
        int count = 3;

        // Makes a selection of 3 words
        while (count > 0){
            Random rand = new Random();
            int index = rand.Next(_scriptureWords.Count);
            string randomChoice = _scriptureWords[index];

            if (randomChoice[1].ToString() != "_"){
                Word newWord = new Word(randomChoice);
                _hiddenWord = newWord.HideWord();
                _scriptureWords[index] = _hiddenWord;
                count -=1;
            }

            // Checks to see if all words have been hidden
            else if (randomChoice[1].ToString() == "_"){
                if (IsCompletelyHidden() == true){
                    break;
                    }
            }
        }
        
    }

    public void GetRenderedText(){
    // Joins the individual words of _scriptureWords array into one string and prints it.
        Console.WriteLine(_scriptureReference);
        _compiledWords = string.Join(" ", _scriptureWords);
        Console.WriteLine(_compiledWords);
        
    }


    public bool IsCompletelyHidden(){
    // Checks if all items in array are hidden by checking to see if all words in the _scriptureWords starts with "_"
        int count = 0;
        foreach (string item in _scriptureWords){
            char check = item[0];
            
            if (check.ToString() == "_"){
                count += 1;
            }
            
        }
        if (count == _scriptureWords.Count()){
            return true;}
        else {
            return false;}
        
        }
    }
