using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class StoryHandler : MonoBehaviour
{
    public int talkedToHugin = 0;
    public int talkedToMunin = 0;

    public int talkedAboutHugin = 0;
    public int talkedAboutMunin = 0;
    public int talkedAboutApple = 0;
    public int talkedAboutMjölnir = 0;
    public int talkedAboutHlidskjalf = 0;
    public int talkedAboutSkidbladnir = 0;
    public int talkedAboutGjallarhorn = 0;
    public int talkedAboutGeri = 0;
    public int talkedAboutDraupnir = 0;
    public int talkedAboutHagalaz = 0;
    public int talkedAboutEiwaz = 0;
    public int talkedAboutMirmir = 0;

    public int helpedWithHugin = 0;
    public int helpedWithMunin = 0;
    public int helpedWithApple = 0;
    public int helpedWithMjölnir = 0;
    public int helpedWithHlidskjalf = 0;
    public int helpedWithSkidbladnir = 0;
    public int helpedWithGjallarhorn = 0;
    public int helpedWithGeri = 0;
    public int helpedWithDraupnir = 0;
    public int helpedWithHagalaz = 0;
    public int helpedWithEiwaz = 0;
    public int helpedWithMirmir = 0;

    public bool madeMouthPiece = false;
    public bool checkedPath = false;
    public bool repairedHorn = false;
    public bool readiedShip = false;
    public bool blewHorn = false;
    public bool storyExplained = false;

    public int talkedSum = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public int CalculateSum()
    {
        talkedSum =
        talkedToHugin +
        talkedToMunin +
        talkedAboutHugin +
        talkedAboutMunin +
        talkedAboutApple +
        talkedAboutMjölnir +
        talkedAboutHlidskjalf +
        talkedAboutSkidbladnir +
        talkedAboutGjallarhorn +
        talkedAboutGeri +
        talkedAboutDraupnir +
        talkedAboutHagalaz +
        talkedAboutEiwaz +
        talkedAboutMirmir +
        helpedWithHugin +
        helpedWithMunin +
        helpedWithApple +
        helpedWithMjölnir +
        helpedWithHlidskjalf +
        helpedWithSkidbladnir +
        helpedWithGjallarhorn +
        helpedWithGeri +
        helpedWithDraupnir +
        helpedWithHagalaz +
        helpedWithEiwaz +
        helpedWithMirmir;
        return talkedSum;
    }

    public void ResetAll()
    {
        talkedToHugin = 0;

        talkedAboutHugin = 0;
        talkedAboutMunin = 0;
        talkedAboutApple = 0;
        talkedAboutMjölnir = 0;
        talkedAboutHlidskjalf = 0;
        talkedAboutSkidbladnir = 0;
        talkedAboutGjallarhorn = 0;
        talkedAboutGeri = 0;
        talkedAboutDraupnir = 0;
        talkedAboutHagalaz = 0;
        talkedAboutEiwaz = 0;
        talkedAboutMirmir = 0;

    }

    public void TooFar()
    {
        GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("This is beyond my grasp.");
    }

    public void NotRight()
    {
        GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Almost.... but something does not seem quite right here.");
    }

    public void ShowPic(Sprite item)
    {
        GameObject.Find("Canvas").transform.Find("Image").GetComponent<Image>().sprite = item;
        GameObject.Find("Canvas").transform.Find("Image").GetComponent<Image>().enabled = true;
    }

    public void ShowPicRight(Sprite item)
    {
        GameObject.Find("Canvas").transform.Find("ImageRight").GetComponent<Image>().sprite = item;
        GameObject.Find("Canvas").transform.Find("ImageRight").GetComponent<Image>().enabled = true;
    }

    public void HuginConversation()
    {
        switch (talkedToHugin)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Ragnarök, the twilight of the gods, is nigh. I have to take preperations.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Yes, you're right, Hugin. I wanted to sail to Mirmir's well and seek counsel.");
                break;
            case 2:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("First I should check the route and ready the ship.");
                break;
            case 3:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Then I need to blow the Gjallarhorn to warn my brothers and the Einherjer.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Path, Ship, Horn. Path, Ship, Horn. Bath, Sheep, Corn. What?!");
                talkedToHugin = -1;
                storyExplained = true;
                break;
        }
        talkedToHugin++;
    }

    public void MuninConversation()
    {
        GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("From my throne I see over all of the nine realms. My route should be visible from there.");

        if (checkedPath == true)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("No wind on my route. Maybe the hammer of the thunder god can put some wind behind my sails.");
        }

        if (readiedShip == true)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("To blow the horn I need a mouth piece. Something in the same colour or material would be suitable. Maybe I can hammer into shape.");
        }

        if (madeMouthPiece == true)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I need to blow the horn to proceed.");
        }

        if (blewHorn == true)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Now I just need to leave. Nevertheless I should pack the boat and check with Mirmir's head.");
        }
    }

    public void MuninInformation()
    {
        switch (talkedAboutMunin)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Munin stores every of my memories. He often helps me, as he forgets nothing.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Especially that one time I had one too many.");
                break;
            case 2:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("YES MUNIN, I was there!");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Maybe I can get some advice from him.");
                talkedAboutMunin = -1;
                break;
        }
        talkedAboutMunin++;
    }

    public void HuginInformation()
    {
        switch (talkedAboutHugin)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Hugin, the thought. Everything that goes through my head goes through his. Together we come to the best conclusions.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Well.... I hope not EVERYTHING.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("With his help I can create the most curious things.");
                talkedAboutHugin = -1;
                break;
        }
        talkedAboutHugin++;
    }

    public void HagalazInformation()
    {
        switch (talkedAboutHagalaz)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("The 'Hagalaz' rune. Destruction, natures forces and the elements are associated with it.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Did I say destruction? That sounds dangerous.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("It seems like what lies on this rune is not to last.");
                talkedAboutHagalaz = -1;
                break;
        }
        talkedAboutHagalaz++;
    }

    public void AppleInformation()
    {
        switch (talkedAboutApple)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("One of Iduns apples that grant eternal life.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I don't feel like eating. These days I only live on mead.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("They are quite enjoyable, nevertheless.");
                talkedAboutApple = -1;
                break;
        }
        talkedAboutApple++;
    }

    public void MjölnirInformation()
    {
        switch (talkedAboutMjölnir)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Aaaaaah. The mightiest weapons among the Aesir: Mjöllnir.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Why does my son always lets his stuff laying around here?");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("The Hammer of the Thunder God will come to good use.");
                talkedAboutMjölnir = -1;
                break;
        }
        talkedAboutMjölnir++;
    }

    public void EiwazInformation()
    {
        switch (talkedAboutEiwaz)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("This rune is called 'Eiwaz'. It represents transformation, fortitude and wisdom.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("What should we transform?");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I wonder how it interacts with the Hagalaz rune.");
                talkedAboutEiwaz = -1;
                break;
        }
        talkedAboutEiwaz++;
    }

    public void HlidskjalfInformation()
    {
        switch (talkedAboutHlidskjalf)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("My throne, Hlidskjalf. From here I can see everything that happens in all the nine realms.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I tell you, some things you do not want to see.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("From there I could investigate my travel route.");
                talkedAboutHlidskjalf = -1;
                break;
        }
        talkedAboutHlidskjalf++;
    }

    public void GjallarhornInformation()
    {
        switch (talkedAboutGjallarhorn)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("A horn that is heard in all Asgard. The Gjallarhorn served us well.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                if (madeMouthPiece)
                {
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("This will certainly warn the Einherjer.");
                }
                else
                {
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("The mouth piece is missing?");
                }
                break;
            default:
                if (madeMouthPiece)
                {
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Lets blow the horn once more.");
                }
                else
                {
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Maybe we can use something else for a mouth piece...");
                }
                talkedAboutGjallarhorn = -1;
                break;
        }
        talkedAboutGjallarhorn++;
    }

    public void SkidbladnirInformation()
    {
        switch (talkedAboutSkidbladnir)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("A ship that can be folded so it fits in a pocket. I never refrain to ponder at Skidbladnir.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("It also serves well as a rubber duck.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Exactly what I need to get to Mirmirs well.");
                talkedAboutSkidbladnir = -1;
                break;
        }
        talkedAboutSkidbladnir++;
    }

    public void DraupnirInformation()
    {
        if (!madeMouthPiece)
        {
            switch (talkedAboutDraupnir)
            {

                case 0:
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Draupnir, the ring that drips nine more alike rings from it in every ninth night. What day do we have?");
                    if (CalculateSum() > 0)
                    {
                        ResetAll();
                    }
                    break;
                case 1:
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Never wear this when you go out with your friends.");
                    break;
                default:
                    GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("What does all the riches in the world mean in the face of doom?");
                    talkedAboutDraupnir = -1;
                    break;
            }
            talkedAboutDraupnir++;
        }
        else
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("This could fit on the Horn. We shall test it!");
        }
    }

    public void GeriInformation()
    {
        switch (talkedAboutGeri)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Geri, my loyal wolf. He seems hungry. Well.... he always does.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Sometimes a little something falls off the table.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Come, doggy doggy.");
                talkedAboutGeri = -1;
                break;
        }
        talkedAboutGeri++;
    }

    public void MirmirInformation()
    {
        switch (talkedAboutMirmir)
        {
            case 0:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("The head of Mirmir. I kept it since it provides wisdom. It seems awefully quiet these days.");
                if (CalculateSum() > 0)
                {
                    ResetAll();
                }
                break;
            case 1:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Such an odd thing.");
                break;
            default:
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Something stirs in it, the closer I get travelling to Mirmirs well.");
                talkedAboutMirmir = -1;
                break;
        }
        talkedAboutMirmir++;
    }


    public void Combine()
    {
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem != null)
        {
            ShowPic(GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem.GetComponent<PicReturn>().ReturnPic());
        }
        if (GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem != null)
        {
            ShowPicRight(GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem.GetComponent<PicReturn>().ReturnPic());
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("gjallerhorn"))
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("The horn is missing a mouthpiece. But this doesn't bring out a tone.");
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("draupnir"))
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Could the ring be used for something else?");
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("mjölnir"))
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I should use the hammer rather to reshape materials.");
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("skidbladnir"))
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("This does not improve the ship.");
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("apple"))
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("This does would just produce applesauce.");
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == null || GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == null)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I will always need two objects to combine");
        }

        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("draupnir") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("mjölnir") && madeMouthPiece == false)
        {
            GameObject.Find("lightning").GetComponent<ParticleSystem>().Play();
            GameObject.Find("lightning").GetComponent<AudioSource>().Play(0);
            madeMouthPiece = true;
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Oh yes, this could looks like it could fit onto the Gjallarhorn.");
        }
        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("mjölnir") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("draupnir") && madeMouthPiece == false)
        {
            NotRight();
        }

        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("gjallerhorn") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("draupnir") && madeMouthPiece == true)
        {
            repairedHorn = true;
            GameObject.Find("DraupnirPs").GetComponent<AudioSource>().Play();
            GameObject.Find("draupnir").SetActive(false);
            GameObject.Find("DraupnirPs").GetComponent<ParticleSystem>().Play();
            GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem = null;
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Now the Gjallarhorn seems ready to be used once again.");
        }

        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("gjallerhorn") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("draupnir") && madeMouthPiece == false)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("It does not fit onto the Gjallarhorn. If I could just do something about it...");
        }

        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("draupnir") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("gjallerhorn") && madeMouthPiece == true)
        {
            NotRight();
        }

        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("skidbladnir") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("mjölnir") && checkedPath == true && readiedShip == false)
        {
            GameObject.Find("lightning").GetComponent<AudioSource>().Play(0);
            GameObject.Find("lightning").GetComponent<ParticleSystem>().Play();
            GameObject.Find("lightning").GetComponent<AudioSource>().Play(0);
            readiedShip = true;
            GameObject.Find("skidbladnir").transform.Find("cloud").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("skidbladnir").transform.Find("storm").GetComponent<ParticleSystem>().Play();
            GameObject.Find("skullPs2").GetComponent<ParticleSystem>().Play();
            GameObject.Find("mirmirHead").GetComponent<AudioSource>().Play();
            if(blewHorn){
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("A ship, that can be sailed without any wind! Now let's get to mirmirs well.");
            }
            else
            {
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Now I just have to warn my brothers with the Gjallarhorn and then travel to Mirmir's well.");
            }
        }

        if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("mjölnir") && GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("skidbladnir") && checkedPath == true)
        {
            NotRight();
        }

        if ((GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == GameObject.Find("skidbladnir") || GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == GameObject.Find("skidbladnir")) && checkedPath == false)
        {
            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Before I do anything with the ship, I should inspect what I must face on my route.");
        }
    }
}
