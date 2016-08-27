using UnityEngine;
using System.Collections;

public class Pictograph : MonoBehaviour
{
    //do we just have a line here for each sprite???
    public Sprite picto001picture;


    public string pictographName;
    public Sprite pictographPicture;

    public Pictograph(string pictoName, Sprite pictoPic)
    {
        pictographName = pictoName;
        pictographPicture = pictoPic;
    }

    //this line seems to not work?? do i need to change from using sprite as the other field?
    //public Pictograph picto001 = new Pictograph(Cow, picto001picture);
}
