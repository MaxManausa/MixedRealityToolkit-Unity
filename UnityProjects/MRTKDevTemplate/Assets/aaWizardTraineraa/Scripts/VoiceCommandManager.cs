using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class VoiceCommandManager : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    [SerializeField] private GameObject naturalFire;
    [SerializeField] private GameObject naturalLightning;
    [SerializeField] private GameObject naturalIce;
    [SerializeField] private GameObject naturalVoid;

    [SerializeField] private GameObject fireSpellCircle;
    [SerializeField] private GameObject fireSpellCircle2;
    [SerializeField] private GameObject fireSpellCircle3;
    
    [SerializeField] private GameObject lightningSpellCircle;
    [SerializeField] private GameObject lightningSpellCircle2;
    [SerializeField] private GameObject lightningSpellCircle3;
    
    [SerializeField] private GameObject iceSpellCircle;
    [SerializeField] private GameObject iceSpellCircle2;
    [SerializeField] private GameObject iceSpellCircle3;
    
    [SerializeField] private GameObject voidSpellCircle;
    [SerializeField] private GameObject voidSpellCircle2;
    [SerializeField] private GameObject voidSpellCircle3;

    [SerializeField] private SpellDescriptions spellDescriptions;
    [SerializeField] private SpellSelector spellSelector;

    [SerializeField] private MoveChild moveChild;

    public GameObject currentSpellCircle;
    
    private void Start()
    {

        // Add your keywords and corresponding actions here
        keywords.Add("Fire Magic", FireAction);
        keywords.Add("Lightning Magic", LightningAction);
        keywords.Add("Ice Magic", IceAction);
        keywords.Add("Void Magic", VoidAction);
        keywords.Add("Natural Form", NaturalAction);
        keywords.Add("First Form", OneAction);
        keywords.Add("Second Form", TwoAction);
        keywords.Add("Third Form", ThreeAction);
        keywords.Add("Attack", GoAction);
        keywords.Add("Serious Volley", SeriousVolleyAction);
        keywords.Add("Stop", StopAction);
        keywords.Add("Switch Hands", SwitchHandsAction);

        // Create the keyword recognizer
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Subscribe to the phrase recognized event
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;

        // Start recognizing
        keywordRecognizer.Start();
        
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        
        // If the recognized keyword is in our dictionary, call the corresponding action
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }

    // Define your action methods here
    public void FireAction()
    {
        Debug.Log("Fire Magic!");
        // Add your code here to perform the 'Fire' action
        spellDescriptions.FireDescription();
        
        spellSelector.naturalFireChose();

        currentSpellCircle = naturalFire;
    }

    public void LightningAction()
    {
        Debug.Log("Lightning Magic!");
        // Add your code here to perform the 'Lightning' action
        spellDescriptions.LightningDescription();
        
        spellSelector.naturalLightningChose();

        currentSpellCircle = naturalLightning;
    }

    public void IceAction()
    {
        Debug.Log("Ice Magic!");
        // Add your code here to perform the 'Ice' action
        spellDescriptions.IceDescription();
        
        spellSelector.naturalIceChose();

        currentSpellCircle = naturalIce;
    }
    
    public void VoidAction()
    {
        Debug.Log("Void Magic!");
        // Add your code here to perform the 'Ice' action
        spellDescriptions.VoidDescription();
        
        spellSelector.naturalVoidChose();

        currentSpellCircle = naturalVoid;
    }

    public void NaturalAction()
    {
        Debug.Log("NaturalForm!");
        if (naturalFire.activeSelf || fireSpellCircle.activeSelf || fireSpellCircle2.activeSelf || fireSpellCircle3.activeSelf)
        {
            spellSelector.naturalFireChose();
            currentSpellCircle = naturalFire;
        }
        else if (naturalLightning.activeSelf || lightningSpellCircle.activeSelf || lightningSpellCircle2.activeSelf || lightningSpellCircle3.activeSelf)
        {
            spellSelector.naturalLightningChose();
            currentSpellCircle = naturalLightning;
        }
        else if (naturalIce.activeSelf || iceSpellCircle.activeSelf || iceSpellCircle2.activeSelf || iceSpellCircle3.activeSelf)
        {
            spellSelector.naturalIceChose();
            currentSpellCircle = naturalIce;
        }
        else if (naturalVoid.activeSelf || voidSpellCircle.activeSelf || voidSpellCircle2.activeSelf || voidSpellCircle3.activeSelf)
        {
            spellSelector.naturalVoidChose();
            currentSpellCircle = naturalVoid;
        }
    }
    
    public void OneAction()
    {
        Debug.Log("First Form!");
        if (naturalFire.activeSelf || fireSpellCircle.activeSelf || fireSpellCircle2.activeSelf || fireSpellCircle3.activeSelf)
        {
            spellSelector.FireChosen();
            currentSpellCircle = fireSpellCircle;
        }
        else if (naturalLightning.activeSelf || lightningSpellCircle.activeSelf || lightningSpellCircle2.activeSelf || lightningSpellCircle3.activeSelf)
        {
            spellSelector.LightningChosen();
            currentSpellCircle =lightningSpellCircle;
        }
        else if (naturalIce.activeSelf || iceSpellCircle.activeSelf || iceSpellCircle2.activeSelf || iceSpellCircle3.activeSelf)
        {
            spellSelector.FrostChosen();
            currentSpellCircle = iceSpellCircle;
        }
        else if (naturalVoid.activeSelf || voidSpellCircle.activeSelf || voidSpellCircle2.activeSelf || voidSpellCircle3.activeSelf)
        {
            spellSelector.VoidChosen();
            currentSpellCircle = voidSpellCircle;
        }
    }
    
    public void TwoAction()
    {
        Debug.Log("Second Form!");
        if (naturalFire.activeSelf || fireSpellCircle.activeSelf || fireSpellCircle2.activeSelf || fireSpellCircle3.activeSelf)
        {
            spellSelector.Fire2Chosen();
            currentSpellCircle = fireSpellCircle2;
        }
        else if (naturalLightning.activeSelf || lightningSpellCircle.activeSelf || lightningSpellCircle2.activeSelf || lightningSpellCircle3.activeSelf)
        {
            spellSelector.Lightning2Chosen();
            currentSpellCircle = lightningSpellCircle2;
        }
        else if (naturalIce.activeSelf || iceSpellCircle.activeSelf || iceSpellCircle2.activeSelf || iceSpellCircle3.activeSelf)
        {
            spellSelector.Frost2Chosen();
            currentSpellCircle = iceSpellCircle2;
        }
        else if (naturalVoid.activeSelf || voidSpellCircle.activeSelf || voidSpellCircle2.activeSelf || voidSpellCircle3.activeSelf)
        {
            spellSelector.Void2Chosen();
            currentSpellCircle = voidSpellCircle2;
        }
    }
    
    public void ThreeAction()
    {
        Debug.Log("Third Form!");
        if (naturalFire.activeSelf || fireSpellCircle.activeSelf || fireSpellCircle2.activeSelf || fireSpellCircle3.activeSelf)
        {
            spellSelector.Fire3Chosen();
            currentSpellCircle = fireSpellCircle3;
        }
        else if (naturalLightning.activeSelf || lightningSpellCircle.activeSelf || lightningSpellCircle2.activeSelf || lightningSpellCircle3.activeSelf)
        {
            spellSelector.Lightning3Chosen();
            currentSpellCircle = lightningSpellCircle3;
        }
        else if (naturalIce.activeSelf || iceSpellCircle.activeSelf || iceSpellCircle2.activeSelf || iceSpellCircle3.activeSelf)
        {
            spellSelector.Frost3Chosen();
            currentSpellCircle = iceSpellCircle3;
        }
        else if (naturalVoid.activeSelf || voidSpellCircle.activeSelf || voidSpellCircle2.activeSelf || voidSpellCircle3.activeSelf)
        {
            spellSelector.Void3Chosen();
            currentSpellCircle = voidSpellCircle3;
        }
    }
    
    private void GoAction()
    {
        Debug.Log("Go firing magic spells!");
        // Fires from current spell circle
        currentSpellCircle.GetComponent<LaunchProjectile>().OnButtonSmash();
    }

    private void SeriousVolleyAction()
    {
        Debug.Log("Serious Form: Here's a volley from my " + currentSpellCircle);
        currentSpellCircle.GetComponent<LaunchProjectile>().RepeatingButtonSmash();
    }
    
    public void StopAction()
    {
        Debug.Log("Stopped firing magic spells");
        // Stops firing from current spell circle
        spellSelector.NonChosen();
        spellDescriptions.ResetBackground();
    }

    public void SwitchHandsAction()
    {
        Debug.Log("Switched Hands on these fools, they not ready");
        // Switches the hand used to fire spells, added because I have friends who are left handed (lame)
        moveChild.SwitchChildParent();
    }
    private void OnDestroy()
    {
        // Dispose the keyword recognizer when the script is destroyed
        if (keywordRecognizer != null)
        {
            keywordRecognizer.Stop();
            keywordRecognizer.Dispose();
        }
    }
}