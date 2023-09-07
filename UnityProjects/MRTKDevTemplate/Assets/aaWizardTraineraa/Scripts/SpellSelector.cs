using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using TMPro;

public class SpellSelector : MonoBehaviour
{
    [SerializeField] private GameObject naturalFire;
    [SerializeField] private GameObject naturalLightning;
    [SerializeField] private GameObject naturalIce;
    [SerializeField] private GameObject naturalVoid;

    [SerializeField] private GameObject fireSpell;
    [SerializeField] private GameObject fireSpell2;
    [SerializeField] private GameObject fireSpell3;
    [SerializeField] private GameObject fireSpellFiringButton;
    [SerializeField] private GameObject fireSpellFiringButton2;
    [SerializeField] private GameObject fireSpellFiringButton3;
    
    [SerializeField] private GameObject lightningSpell;
    [SerializeField] private GameObject lightningSpell2;
    [SerializeField] private GameObject lightningSpell3;
    [SerializeField] private GameObject lightningSpellFiringButton;
    [SerializeField] private GameObject lightningSpellFiringButton2;
    [SerializeField] private GameObject lightningSpellFiringButton3;
    
    [SerializeField] private GameObject frostSpell;
    [SerializeField] private GameObject frostSpell2;
    [SerializeField] private GameObject frostSpell3;
    [SerializeField] private GameObject frostSpellFiringButton;
    [SerializeField] private GameObject frostSpellFiringButton2;
    [SerializeField] private GameObject frostSpellFiringButton3;
    
    [SerializeField] private GameObject voidSpell;
    [SerializeField] private GameObject voidSpell2;
    [SerializeField] private GameObject voidSpell3;
    [SerializeField] private GameObject voidFiringButton;
    [SerializeField] private GameObject voidFiringButton2;
    [SerializeField] private GameObject voidFiringButton3;

    [SerializeField] private GameObject spellFiringButtonsHolder;
    [SerializeField] private AudioSource gameAudio;
     
    [SerializeField] private GameObject spellBook;
    [SerializeField] private GameObject settingsPage;
    [SerializeField] private GameObject trainingPage;
    [SerializeField] private GameObject trainingRoom1;
    [SerializeField] private GameObject trainingRoom2;
    [SerializeField] private GameObject wizardRoom;

    public void ShowHideSpellBook()
    {
        if(spellBook.activeSelf)
        {
            spellBook.SetActive(false);
        }
        else
        {
            spellBook.SetActive(true);
        }
    }
    
    public void ShowHideSettingsPage()
    {
        if(settingsPage.activeSelf)
        {
            settingsPage.SetActive(false);
        }
        else
        {
            settingsPage.SetActive(true);
        }
    }

    public void ShowHideTrainingPage()
    {
        if (trainingPage.activeSelf)
        {
            trainingPage.SetActive(false);
        }
        else
        {
            trainingPage.SetActive(true);
        }
    }

    public void ShowHideTrainingRoom1()
    {
        if (trainingRoom1.activeSelf)
        {
            trainingRoom1.SetActive(false);
        }
        else
        {
            trainingRoom1.SetActive(true);
        }
    }

    public void ShowHideTrainingRoom2()
    {
        if (trainingRoom2.activeSelf)
        {
            trainingRoom2.SetActive(false);
        }
        else
        {
            trainingRoom2.SetActive(true);
        }
    }

    public void ShowHideWizardRoom()
    {
        if (wizardRoom.activeSelf)
        {
            wizardRoom.SetActive(false);
        }
        else
        {
            wizardRoom.SetActive(true);
        }
    }

    public void ShowHideSpellFiringButtons()
    {
        if(spellFiringButtonsHolder.activeSelf)
        {
            spellFiringButtonsHolder.SetActive(false);
        }
        else
        {
            spellFiringButtonsHolder.SetActive(true);
        }
    }
    
    public void OnOffGameAudio()
    {
        if(gameAudio.enabled)
        {
            gameAudio.enabled = false;
        }
        else
        {
            gameAudio.enabled = true;
        }
    }
    
    public void NonChosen()
    {
        naturalFire.SetActive(false);
        naturalLightning.SetActive(false);
        naturalIce.SetActive(false);    
        naturalVoid.SetActive(false);

        fireSpell.SetActive(false);
        fireSpellFiringButton.SetActive(false);
        lightningSpell.SetActive(false);
        lightningSpellFiringButton.SetActive(false);
        frostSpell.SetActive(false);
        frostSpellFiringButton.SetActive(false);
        voidSpell.SetActive(false);
        voidFiringButton.SetActive(false);
        
        fireSpell2.SetActive(false);
        fireSpellFiringButton2.SetActive(false);
        lightningSpell2.SetActive(false);
        lightningSpellFiringButton2.SetActive(false);
        frostSpell2.SetActive(false);
        frostSpellFiringButton2.SetActive(false);
        voidSpell2.SetActive(false);
        voidFiringButton2.SetActive(false);
        
        fireSpell3.SetActive(false);
        fireSpellFiringButton3.SetActive(false);
        lightningSpell3.SetActive(false);
        lightningSpellFiringButton3.SetActive(false);
        frostSpell3.SetActive(false);
        frostSpellFiringButton3.SetActive(false);
        voidSpell3.SetActive(false);
        voidFiringButton3.SetActive(false);
    }

    public void NoFiringButtonsChosen()
    {
        fireSpell.SetActive(false);
        fireSpellFiringButton.SetActive(false);
        lightningSpell.SetActive(false);
        lightningSpellFiringButton.SetActive(false);
        frostSpell.SetActive(false);
        frostSpellFiringButton.SetActive(false);
        voidSpell.SetActive(false);
        voidFiringButton.SetActive(false);

        fireSpell2.SetActive(false);
        fireSpellFiringButton2.SetActive(false);
        lightningSpell2.SetActive(false);
        lightningSpellFiringButton2.SetActive(false);
        frostSpell2.SetActive(false);
        frostSpellFiringButton2.SetActive(false);
        voidSpell2.SetActive(false);
        voidFiringButton2.SetActive(false);

        fireSpell3.SetActive(false);
        fireSpellFiringButton3.SetActive(false);
        lightningSpell3.SetActive(false);
        lightningSpellFiringButton3.SetActive(false);
        frostSpell3.SetActive(false);
        frostSpellFiringButton3.SetActive(false);
        voidSpell3.SetActive(false);
        voidFiringButton3.SetActive(false);
    }

    public void AllChosen()
    {
        naturalFire.SetActive(true);
        naturalLightning.SetActive(true);
        naturalIce.SetActive(true);
        naturalVoid.SetActive(true);

        fireSpell.SetActive(true);
        fireSpell2.SetActive(true);
        fireSpell3.SetActive(true);
        
        lightningSpell.SetActive(true);
        lightningSpell2.SetActive(true);
        lightningSpell3.SetActive(true);
        
        frostSpell.SetActive(true);
        frostSpell2.SetActive(true);
        frostSpell3.SetActive(true);
        
        voidSpell.SetActive(true);
        voidSpell2.SetActive(true);
        voidSpell3.SetActive(true);
    }
    
    public void naturalFireChose()
    {
        NonChosen();
        naturalFire.SetActive(true);
        NoFiringButtonsChosen();
    }
    public void naturalLightningChose()
    {
        NonChosen();
        naturalLightning.SetActive(true);
        NoFiringButtonsChosen();
    }

    public void naturalIceChose()
    {
        NonChosen();
        naturalIce.SetActive(true);
        NoFiringButtonsChosen();
    }

    public void naturalVoidChose()
    {
        NonChosen();
        naturalVoid.SetActive(true);
        NoFiringButtonsChosen();
    }

    public void FireChosen()
    {
        NonChosen();
        fireSpell.SetActive(true);
        fireSpellFiringButton.SetActive(true);
    }
    
    public void Fire2Chosen()
    {
        NonChosen();
        fireSpell2.SetActive(true);
        fireSpellFiringButton2.SetActive(true);
    }
    
    public void Fire3Chosen()
    {
        NonChosen();
        fireSpell3.SetActive(true);
        fireSpellFiringButton3.SetActive(true);
    }

    public void LightningChosen()
    {
        NonChosen();
        lightningSpell.SetActive(true);
        lightningSpellFiringButton.SetActive(true);
    }
    
    public void Lightning2Chosen()
    {
        NonChosen();
        lightningSpell2.SetActive(true);
        lightningSpellFiringButton2.SetActive(true);
    }
    
    public void Lightning3Chosen()
    {
        NonChosen();
        lightningSpell3.SetActive(true);
        lightningSpellFiringButton3.SetActive(true);
    }
    
    public void FrostChosen()
    {
        NonChosen();
        frostSpell.SetActive(true);
        frostSpellFiringButton.SetActive(true);
    }
    
    public void Frost2Chosen()
    {
        NonChosen();
        frostSpell2.SetActive(true);
        frostSpellFiringButton2.SetActive(true);
    }
    
    public void Frost3Chosen()
    {
        NonChosen();
        frostSpell3.SetActive(true);
        frostSpellFiringButton3.SetActive(true);
    }
    public void VoidChosen()
    {
        NonChosen();
        voidSpell.SetActive(true);
        voidFiringButton.SetActive(true);
    }
    
    public void Void2Chosen()
    {
        NonChosen();
        voidSpell2.SetActive(true);
        voidFiringButton2.SetActive(true);
    }
    
    public void Void3Chosen()
    {
        NonChosen();
        voidSpell3.SetActive(true);
        voidFiringButton3.SetActive(true);
    }

    
}
