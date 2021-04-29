using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    List<string> nounList = new List<string>();
    List<string> adjList = new List<string>();
    List<string> verbList = new List<string>();
    List<string> adverbList = new List<string>();

    //myList.ElementAt(0);
    public string textValue;
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {
        nounList.Add("Conference call");
        nounList.Add("Zoom");
        nounList.Add("Dashboard");
        nounList.Add("Community");
        nounList.Add("ROI");
        nounList.Add("PR");
        nounList.Add("Best practice");
        nounList.Add("Process");
        nounList.Add("Schema");
        nounList.Add("Solutions");
        nounList.Add("Technology");
        nounList.Add("UI");
        nounList.Add("Users");
        nounList.Add("Strategery");
        nounList.Add("Client");
        nounList.Add("Project plan");
        nounList.Add("PIA");
        nounList.Add("Architect");
        nounList.Add("Engineer");
        nounList.Add("Architecture");
        nounList.Add("CCL");
        nounList.Add("Java");
        nounList.Add("Scrum");
        nounList.Add("Professional");
        nounList.Add("Metrics");
        nounList.Add("Goals");
        nounList.Add("Bandwidth");
        nounList.Add("Core Competencies");
        nounList.Add("Forecast");
        nounList.Add("Value Stream");
        nounList.Add("Project Number");
        nounList.Add("Gobbledygook");
        nounList.Add("Diversity & Inclusion");
        nounList.Add("Portal");
        nounList.Add("Low-hanging fruit");
        nounList.Add("Key program");
        nounList.Add("Initiatives");
        nounList.Add("Domination");
        nounList.Add("Ballpark estimate");
        nounList.Add("DevOps");
        nounList.Add("Security");
        nounList.Add("Username");
        nounList.Add("Password");
        nounList.Add("Influencer");
        nounList.Add("Billable utilization");
        nounList.Add("Value proposition");
        nounList.Add("Pain points");
        nounList.Add("Pushback");

        adjList.Add("Agile");
        adjList.Add("Functional");
        adjList.Add("Flexible");
        adjList.Add("Excellent");
        adjList.Add("Dynamic");
        adjList.Add("Distinct");
        adjList.Add("Debatable");
        adjList.Add("Informative");
        adjList.Add("Uninformative");
        adjList.Add("Sarcastic");
        adjList.Add("Careless");
        adjList.Add("Frumpy");
        adjList.Add("Cluttered");
        adjList.Add("Uncluttered");
        adjList.Add("Infallible");
        adjList.Add("Legible");
        adjList.Add("2000");
        adjList.Add("Distracting");
        adjList.Add("Concerned");
        adjList.Add("Revealing");
        adjList.Add("Extraneous");
        adjList.Add("Professional");
        adjList.Add("Client-centered");
        adjList.Add("Credible");
        adjList.Add("ubiquitous");
        adjList.Add("Sticky");
        adjList.Add("Action items");
        adjList.Add("Domain");
        adjList.Add("Mission crititcal");
        adjList.Add("High Level");

        verbList.Add("Share");
        verbList.Add("Land (as in when we land on something)");
        verbList.Add("Reswizzle");
        verbList.Add("Iterate");
        verbList.Add("Generate");
        verbList.Add("Engage");
        verbList.Add("Implement");
        verbList.Add("Integrate");
        verbList.Add("Push");
        verbList.Add("Pull");
        verbList.Add("Collaborate");
        verbList.Add("Unleash");
        verbList.Add("Develop");
        verbList.Add("Expedite");
        verbList.Add("Exploit");
        verbList.Add("Facilitate");
        verbList.Add("Strategize");
        verbList.Add("Leverage");
        verbList.Add("Utilize");
        verbList.Add("Underwhelm");
        verbList.Add("Overwhelm");
        verbList.Add("Incentivize");
        verbList.Add("Forecasting");
        verbList.Add("Forecasted");
        verbList.Add("Repurpose");
        verbList.Add("Reinvent");
        verbList.Add("Streamline");
        verbList.Add("Transform");
        verbList.Add("Utilize");
        verbList.Add("Optimize");
        verbList.Add("Innovate");
        verbList.Add("Exploit");
        verbList.Add("Parse");
        verbList.Add("Circle back around");
        verbList.Add("Close the loop");
        verbList.Add("Drill down");
        verbList.Add("Ping");
        verbList.Add("Elevate");
        verbList.Add("Transform");
        verbList.Add("Deliver");
        verbList.Add("Accelerate");
        verbList.Add("Include");
        verbList.Add("Engage");
        verbList.Add("Collaborate");
        verbList.Add("Innovate");
        verbList.Add("Simplify");
        verbList.Add("Commit");
        verbList.Add("Behave");
        verbList.Add("Capitalize");
        verbList.Add("Level up");
        verbList.Add("Pivot");
        verbList.Add("Disrupt");
        verbList.Add("Unpack");
        verbList.Add("Loop in");
        verbList.Add("Touchbase");
        verbList.Add("Align");

        adverbList.Add("Quickly");
        adverbList.Add("Seamlessly");
        adverbList.Add("Dynamically");
        adverbList.Add("Efficiently");
        adverbList.Add("Frantically");
        adverbList.Add("Supposedly");
        adverbList.Add("Offensively");
        adverbList.Add("Bitterly");
        adverbList.Add("Greatly");
        adverbList.Add("Extremely");
        adverbList.Add("Furiously");
        adverbList.Add("Jaggedly");
        adverbList.Add("Suddenly");
        adverbList.Add("Abnormally");
        adverbList.Add("Roughly");
        adverbList.Add("Randomly");
        adverbList.Add("Wearily");
        adverbList.Add("Judgmentally");
        adverbList.Add("Unenthusiastically");

        GameEvents.current.onShakeStart += onShake;
    }

    private void onShake()
    {
        textElement.color = new Color(
                textElement.color.r,
                textElement.color.g,
                textElement.color.b,
                0.0f);

        //textElement.text = getPhrase( Random.Range(0, 9));
        textElement.text = getMadLibPhrasePhrase(
            Random.Range(0, nounList.Count+1)
            ,Random.Range(0, adjList.Count+1)
            ,Random.Range(0, verbList.Count+1)
            ,Random.Range(0, adverbList.Count+1));
    }

    private string getPhrase(int phraseIdx)
    {
        string phrase = "";
        switch(phraseIdx)
        {
            case 1:
                phrase = "Sure";
                break;
            case 2:
                phrase = "Why would I care?";
                break;
            case 3:
                phrase = "Hmmm I don't know about this";
                break;
            case 4:
                phrase = "I mean that will work...";
                break;
            case 5:
                phrase = "Absolutly...";
                break;
            case 6:
                phrase = "No";
                break;
            case 7:
                phrase = "Not enough information to answer. Try again";
                break;
            case 8:
                phrase = "Yeah... I'm going to have to ask you to come in on Saturday";
                break;
            default:
                phrase = "I don't know how we ended up here";
                break;
        }
        return phrase;
    }

    private string getMadLibPhrasePhrase(int nounIDX,int adjIDX,int verbIDX,int adverbIDX)
    {
        string phrase = "";
        phrase += " "+adverbList[adverbIDX];
        phrase += " "+verbList[verbIDX];
        phrase += " "+adjList[adjIDX];
        phrase += " "+nounList[nounIDX];
        
        

        return phrase;
    }
}
