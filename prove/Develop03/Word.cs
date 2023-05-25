public class Word {

public bool _isHidden;
private string _word;
    
public Word (string word){
    _word = word;
    } 

public string HideWord(){
    // Takes random word input from Scripture Class and converts it to underscores.
    // --> Creativity: Number of underscores match the number of letters
    
    _isHidden = true;
    char[] charArray = _word.ToCharArray();
    string[] hiddenArray = Array.ConvertAll(charArray, element => "_"); 
    string newWord = string.Join("",hiddenArray); 
    return newWord;
}

}
