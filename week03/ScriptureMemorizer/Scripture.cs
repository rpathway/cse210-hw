public class Scripture
{
  private static List<Scripture> _scriptureLibrary = new List<Scripture>();
  private static string _filePath = "lds-scriptures.txt";

  private Reference _reference;
  private List<Word> _words = new List<Word>();

  public Scripture(Reference reference, string text)
  {
    _reference = reference;

    string[] splitText = text.Split(' ');
    foreach (string word in splitText)
    {
      _words.Add(new Word(word));
    }
  }

  public static void LoadFromFile()
  {
    List<string> _fileLines;

    if (!File.Exists(_filePath))
    {
      _fileLines = new List<string> {
        "Proverbs 15:1     A soft answer turneth away wrath: but grievous words stir up anger.",
        "Proverbs 15:3     The eyes of the Lord are in every place, beholding the evil and the good.",
        "Proverbs 15:9     The way of the wicked is an abomination unto the Lord: but he loveth him that followeth after righteousness.",
        "Proverbs 15:16     Better is little with the fear of the Lord than great treasure and trouble therewith.",
        "Proverbs 15:28     The heart of the righteous studieth to answer: but the mouth of the wicked poureth out evil things.",
        "Proverbs 15:32     He that refuseth instruction despiseth his own soul: but he that heareth reproof getteth understanding.",
        "Proverbs 15:33     The fear of the Lord is the instruction of wisdom; and before honour is humility.",
        "Matthew 26:53     Thinkest thou that I cannot now pray to my Father, and he shall presently give me more than twelve legions of angels?",
        "James 1:3     Knowing this, that the trying of your faith worketh patience.",
        "James 2:19     Thou believest that there is one God; thou doest well: the devils also believe, and tremble.",
        "James 3:5     Even so the tongue is a little member, and boasteth great things. Behold, how great a matter a little fire kindleth!",
        "James 3:8     But the tongue can no man tame; it is an unruly evil, full of deadly poison.",
        "James 3:11     Doth a fountain send forth at the same place sweet water and bitter?",
        "James 4:8     Draw nigh to God, and he will draw nigh to you. Cleanse your hands, ye sinners; and purify your hearts, ye double minded.",
        "James 5:1     Go to now, ye rich men, weep and howl for your miseries that shall come upon you.",
        "James 5:20     Let him know, that he which converteth the sinner from the error of his way shall save a soul from death, and shall hide a multitude of sins.",
        "Revelation 6:16     And said to the mountains and rocks, Fall on us, and hide us from the face of him that sitteth on the throne, and from the wrath of the Lamb:",
        "Jacob 6:13     Finally, I bid you farewell, until I shall meet you before the pleasing bar of God, which bar striketh the wicked with awful dread and fear. Amen.",
        "Mosiah 2:25     And now I ask, can ye say aught of yourselves? I answer you, Nay. Ye cannot say that ye are even as much as the dust of the earth; yet ye were created of the dust of the earth; but behold, it belongeth to him who created you.",
        "Mosiah 4:11     And again I say unto you as I have said before, that as ye have come to the knowledge of the glory of God, or if ye have known of his goodness and have tasted of his love, and have received a remission of your sins, which causeth such exceedingly great joy in your souls, even so I would that ye should remember, and always retain in remembrance, the greatness of God, and your own nothingness, and his goodness and long-suffering towards you, unworthy creatures, and humble yourselves even in the depths of humility, calling on the name of the Lord daily, and standing steadfastly in the faith of that which is to come, which was spoken by the mouth of the angel.",
        "Alma 5:37     O ye workers of iniquity; ye that are puffed up in the vain things of the world, ye that have professed to have known the ways of righteousness nevertheless have gone astray, as sheep having no shepherd, notwithstanding a shepherd hath called after you and is still calling after you, but ye will not hearken unto his voice!",
        "Alma 5:52     And again I say unto you, the Spirit saith: Behold, the ax is laid at the root of the tree; therefore every tree that bringeth not forth good fruit shall be hewn down and cast into the fire, yea, a fire which cannot be consumed, even an unquenchable fire. Behold, and remember, the Holy One hath spoken it.",
        "Alma 7:14     Now I say unto you that ye must repent, and be born again; for the Spirit saith if ye are not born again ye cannot inherit the kingdom of heaven; therefore come and be baptized unto repentance, that ye may be washed from your sins, that ye may have faith on the Lamb of God, who taketh away the sins of the world, who is mighty to save and to cleanse from all unrighteousness.",
        "Alma 12:14     For our words will condemn us, yea, all our works will condemn us; we shall not be found spotless; and our thoughts will also condemn us; and in this awful state we shall not dare to look up to our God; and we would fain be glad if we could command the rocks and the mountains to fall upon us to hide us from his presence.",
        "Alma 36:13     Yea, I did remember all my sins and iniquities, for which I was tormented with the pains of hell; yea, I saw that I had rebelled against my God, and that I had not kept his holy commandments.",
        "Alma 36:15     Oh, thought I, that I could be banished and become extinct both soul and body, that I might not be brought to stand in the presence of my God, to be judged of my deeds.",
        "Moroni 7:8     For behold, if a man being evil giveth a gift, he doeth it grudgingly; wherefore it is counted unto him the same as if he had retained the gift; wherefore he is counted evil before God.",
        "Moroni 7:10     Wherefore, a man being evil cannot do that which is good; neither will he give a good gift.",
        "Moroni 7:11     For behold, a bitter fountain cannot bring forth good water; neither can a good fountain bring forth bitter water; wherefore, a man being a servant of the devil cannot follow Christ; and if he follow Christ he cannot be a servant of the devil.",
        "Moroni 7:12     Wherefore, all things which are good cometh of God; and that which is evil cometh of the devil; for the devil is an enemy unto God, and fighteth against him continually, and inviteth and enticeth to sin, and to do that which is evil continually.",
        "Moroni 7:16     For behold, the Spirit of Christ is given to every man, that he may know good from evil; wherefore, I show unto you the way to judge; for every thing which inviteth to do good, and to persuade to believe in Christ, is sent forth by the power and gift of Christ; wherefore ye may know with a perfect knowledge it is of God.",
        "Moroni 7:38     For no man can be saved, according to the words of Christ, save they shall have faith in his name; wherefore, if these things have ceased, then has faith ceased also; and awful is the state of man, for they are as though there had been no redemption made.",
        "Moroni 10:34     And now I bid unto all, farewell. I soon go to rest in the paradise of God, until my spirit and body shall again reunite, and I am brought forth triumphant through the air, to meet you before the pleasing bar of the great Jehovah, the Eternal Judge of both quick and dead. Amen.",
        "Doctrine and Covenants 61:20     I, the Lord, was angry with you yesterday, but today mine anger is turned away.",
        "Doctrine and Covenants 63:47     He that is faithful and endureth shall overcome the world.",
        "Doctrine and Covenants 64:29     Wherefore, as ye are agents, ye are on the Lord's errand; and whatever ye do according to the will of the Lord is the Lord's business.",
        "Doctrine and Covenants 95:2     Wherefore, ye must needs be chastened and stand rebuked before my face;"
      };
    }
    else
    {
      _fileLines = File.ReadAllLines(_filePath).ToList();
    }

    foreach (string line in _fileLines)
    {
      if (string.IsNullOrWhiteSpace(line)) continue;

      string[] parts = line.Split("     ");
      if (parts.Length < 2) continue;

      Reference reference = ParseBookReference(parts[0].Trim());
      string text = parts[1].Trim();

      if (reference != null && !string.IsNullOrEmpty(text))
      {
        _scriptureLibrary.Add(new Scripture(reference, text));
      }
    }
  }

  private static Reference ParseBookReference(string bookReference)
  {
    string[] parts = bookReference.Split(' ');
    string referenceIndex = Array.Find(parts, reference => reference.Contains(':'));
    string book = string.Join(" ", parts.Take(parts.Length - 1));

    string[] chapterVerse = referenceIndex.Split(':');
    int chapter = int.Parse(chapterVerse[0]);
    int verse   = int.Parse(chapterVerse[1]);

    return new Reference(book, chapter, verse);
  }

  public static Scripture GetRandomScripture()
  {
    int index = Random.Shared.Next(_scriptureLibrary.Count);
    return _scriptureLibrary[index];
  }

  public static int GetScriptureCount()
  {
    return _scriptureLibrary.Count;
  }

  public void HideRandomWords(int numberToHide)
  {
    if (numberToHide < _words.Count)
    {
      _words[numberToHide].Hide();
    }
  }

  public string GetDisplayText()
  {
    string compiledVerse = $"{_reference.GetDisplayText()}";
    foreach (Word verseWord in _words)
    {
      compiledVerse += $" {verseWord.GetDisplayText()}";
    }

    return compiledVerse;
  }

  public bool IsCompletelyHidden()
  {
    return _words.All(w => w.IsHidden());
  }

  public int GetWordCount()
  {
    return _words.Count;
  }
}