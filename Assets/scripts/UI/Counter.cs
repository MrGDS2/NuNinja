
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour {

	public Text score;
    public Text pScore;
    public Text gScore;
    public Text veggie;
    public Text fScore;
    public Text oScore;
    public Text dScore;

    public static string type = "";
    public static int amount = 0;
    public static int pAmount = 0;
    public static int gAmount = 0;
    public static int vAmount = 0;
    public static int dAmount = 0;
    public static int fAmount = 0;
    public static int oAmount = 0;



	public static Counter instance;
	Color goal=new Color32(0x33,0xFF,0x00,0xFF);
	public void Start()
	{
        score = GameObject.Find("score").GetComponent<Text>();
        pScore = GameObject.Find("protein").GetComponent<Text>();
        gScore = GameObject.Find("graincount").GetComponent<Text>();
        fScore = GameObject.Find("fruit").GetComponent<Text>();
        veggie = GameObject.Find("veggie").GetComponent<Text>();
        dScore = GameObject.Find("dairy").GetComponent<Text>();
        oScore = GameObject.Find("oils").GetComponent<Text>();

		instance = this;

    }

	// Update is called once per frame
    public void Update () 
    {
        
        if(type == "protein")
        {
            Debug.Log("protein" + " hit.");
            type = "";
            score.text = "Score: " + amount.ToString();
            pScore.text = pAmount.ToString();
			Colorset(goal);
        }
        else if(type == "grain"){
            Debug.Log("grain" + " hit.");
            type = "";
            score.text = "Score: " + amount.ToString();
            gScore.text = gAmount.ToString();
			Colorset(goal);
        }
        else if (type=="fruit"){
            score.text = "Score: " + amount.ToString();
            fScore.text = fAmount.ToString();
			Colorset(goal);
        }
        else if (type == "veggie")
        {
            score.text = "Score: " + amount.ToString();
            veggie.text = vAmount.ToString();
			Colorset(goal);
        }
        else if (type == "grain")
        {
            score.text = "Score: " + amount.ToString();
            gScore.text = gAmount.ToString();
			Colorset(goal);
        }
        else if (type == "dairy")
        {
            score.text = "Score: " + amount.ToString();
            dScore.text = dAmount.ToString();
			Colorset(goal);
		   }
        else if (type == "oils")
        {
            score.text = "Score: " + amount.ToString();
            oScore.text = oAmount.ToString();
			Colorset (Color.red);
            //fruit[0] = Counting();
        }
   

	}



	Color Colorset(Color col)
	{

		return score.color = col;

	}
}
