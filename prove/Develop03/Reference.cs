public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerseNum;
    private int _endVerseNum;
    private bool _hasSecondVerse;
    private string _scriptureReference;

public Reference(string book, int chapter, int beginningVerse){
// Constructor:  Book, Chapter and One Verse given
    this._book = book;
    this._chapter = chapter;
    _startVerseNum = beginningVerse;
    _hasSecondVerse = false;
}

public Reference(string book, int chapter, int beginningVerse, int endingVerse){
// Constructor: Book, Chapter, and Multiple Verses given
    this._book = book;
    this._chapter = chapter;
    _startVerseNum = beginningVerse;
    _endVerseNum = endingVerse;
    _hasSecondVerse = true;
}

    public string DisplayReference(){
    // Creates the full reference for display, with accommodation for multiple verses
        if (_hasSecondVerse == false){
            _scriptureReference = $"{_book} {_chapter}:{_startVerseNum}";
        }
        else{
            _scriptureReference = $"{_book} {_chapter}:{_startVerseNum}-{_endVerseNum}";
        }
        return _scriptureReference;
    }
}

