public class GoalManager{
    private int _score;
    private string _currentLevel;
    private string _animalLevel;
    private bool _levelUp;
    Dictionary<string, string> animals = new Dictionary<string, string>(){
        {"Jerboa", "A Jerboa is an adorable desert rodent that looks like a mouse mixed with a kangaroo.  It uses its long legs to get around by hopping!  It can hop as far as 3 meters in one jump, and at speeds up to 24 km/h, making it difficult for predators to catch them."},
        {"Pink Fairy Armadillo", "Native to the desert region of Argentina, the Pink Fairy Armadillo is the tinniest species of armadillo in the world.  The pink color of their dorsal shell is due to the network of blood vessels underneath. It has large claws on both its front and hind legs to dig into the sand."},
        {"Colugo", "Also known as 'Flying Lemurs', the Colugo dwells high in the trees of South East Asia.  They glide to get from tree to tree, eating leaves, flowers and fruit. They're nocturnal, but their large adorable eyes help them to see perfectly at night."},
        {"Matamata", "Unless you knew what you were looking at, you'd probably mistake Matamatas for a brand with large flat leaves! These South American flat-backed turtles live in the muddy bottoms of slow-moving and shallow water.  Their snorkle-like snout allows them to get air with minimal exposure to the above-world."},
        {"Coatimundi", "A Coatimundiu looks like a cross between a racoon and a lemur, and could easily be mistaken for a stuffed animal.  These highly intelligent creatures are found in South and Central America, and are unique for the wide variety of habitats they can be found in.  Found both in treetops and cliff faces, they can be found foraging for food both in the canopy and on the ground. They can also survive altitudes over over 8,000 feet!"},
        {"Binturong", "Binturongs, or 'bearcats' may look like something that Dr. Seuss cooked up with their cat-like face and bear-like body, but the most far-fetched thing about them is their smell -- they smell like buttered popcorn! They are also one of only two carnivores with prehensile tails."},
        {"Fossa", "Like most other species living there, the Fossa is endemic to Madagascar. Though they may look like other cat species, they're more closely related to the mongoose.  They're an unusually quiet predator for their size; they communicate primarily through scent, but they may roar to intimidate another fossa or act in defense."},
        {"Saiga", "The Saiga looks like your normal antelope from the neck down, but has a hanging nose that is reminiscent of a camel. Their humped nose helps to filter the dust kicked out by the herd. Though they once roamed a vast region of Eurasia, they've become extinct in many regions due to overhunting. Even though hunting Saiga is now illegal, it unfortunately is still a very common practice. Many local cultures use their horns for medicinal purposes, and their skin is considered very valuable as well."},
        {"Maned Wolf", "Described as a 'fox on stilts', the Maned Wolf technically is not a fox nor a wolf, but its very own genus.  It has the longest legs of all carnivores in proportion to the body. These long legs help them to see above the tall grass where they most often hunt."},
        {"Arapaima", "The Arapaima are a giant prehistoric fish that are native to the Amazon River Basin as well as its nearby lakes and swamps.  They can grow up to 15 feet long, can weigh over 400 pounds, and are air-breathers! By watching it, you may think that an Arapaima is slow-moving, but these fierce predators save their speed for when they leap out of the water to grab birds, lizards, and even small primates from low-hanging trees."},
    };

    public int GetScore(){
        return _score;
    }

    public string GetAnimal(){

        return GetLevel();
    }

    public void ResetScore(int newScore){
        _score = newScore;
    }

    public void ResetAnimal(string newAnimal){
        _animalLevel = newAnimal;
    }

    public void SetScore(int pointAmt){
        _score += pointAmt;
    }

    public string GetLevel(){
        if (_score <= 100){
            _animalLevel = "Jerboa";
        }
        else if (_score > 100 && _score <= 200){
            _animalLevel = "Pink Fairy Armadillo";
        }
        else if (_score > 200 && _score <= 300){
            _animalLevel = "Colugo";
        }
        else if (_score > 300 && _score <= 450){
            _animalLevel = "Matamata";
        }
        else if (_score > 450 && _score <= 600){
            _animalLevel = "Coatimundi";
        }
        else if (_score > 600 && _score <= 800){
            _animalLevel = "Binturong";
        }
        else if (_score > 800 && _score <= 1000){
            _animalLevel = "Fossa";
        }
        else if (_score > 1000 && _score <= 1400){
            _animalLevel = "Saiga";
        }
        else if (_score > 1400 && _score <= 1800){
            _animalLevel = "Maned Wolf";
        }
        else {
            _animalLevel = "Arapaima";
        }
        return _animalLevel;
    }

    public string GetDescription(){
        return animals[_animalLevel];
    }
    public void CheckIncrease(){
        if (_currentLevel == GetLevel()){
            _levelUp = false;
        }
        else if (_currentLevel != GetLevel()){
            _levelUp = true;
            _currentLevel = _animalLevel;
        }
        
        if (_levelUp == true){
            Console.WriteLine( $"Congratulations! You've leveled up!  You are now a {_currentLevel}!");
        }
    }

    
}