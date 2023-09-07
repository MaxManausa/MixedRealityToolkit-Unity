using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpellDescriptions : MonoBehaviour
{
    [SerializeField] private TMP_Text spellDescription1;
    [SerializeField] private TMP_Text spellDescription2;
    [SerializeField] private TMP_Text spellDescription3;

    [SerializeField] private MeshRenderer descriptionBackground1;
    [SerializeField] private MeshRenderer descriptionBackground2;
    [SerializeField] private MeshRenderer descriptionBackground3;

    [SerializeField] private MeshRenderer spellBookBackground;

    [SerializeField] private Material fireMaterial;
    [SerializeField] private Material lightningMaterial;
    [SerializeField] private Material iceMaterial;
    [SerializeField] private Material voidMaterial;

    [SerializeField] private Material basicBackgroundMaterial;
    [SerializeField] private Material basicDescriptionBackgroundMaterial;


    public void FireDescription()
    {
        spellDescription1.text = "Fire Ball:\n" + " 'Fire Magic' + 'First Form' + 'Attack'";
        spellDescription2.text = "Fire Slash:\n" + " 'Fire Magic' + 'Second Form' + 'Attack'";
        spellDescription3.text = "Meteor Strike:\n" + " 'Fire Magic' + 'Third Form' + 'Attack'";
        spellBookBackground.material = fireMaterial;
        descriptionBackground1.material = fireMaterial;
        descriptionBackground2.material = fireMaterial;
        descriptionBackground3.material = fireMaterial;
    }
    
    public void LightningDescription()
    {
        spellDescription1.text = "Lightning Ball:\n" + " 'Lightning Magic' + 'First Form' + 'Attack'";
        spellDescription2.text = "Shockwave:\n" + " 'Lightning Magic' + 'Second Form' + 'Attack'";
        spellDescription3.text = "EMP:\n" + " 'Lightning Magic' + 'Third Form' + 'Attack'";
        spellBookBackground.material = lightningMaterial;
        descriptionBackground1.material = lightningMaterial;
        descriptionBackground2.material = lightningMaterial;
        descriptionBackground3.material = lightningMaterial;
    }
    
    public void IceDescription()
    {
        spellDescription1.text = "Snowball:\n" + " 'Ice Magic' + 'First Form' + 'Attack'";
        spellDescription2.text = "Chill Wave:\n" + " 'Ice Magic' + 'Second Form' + 'Attack'";
        spellDescription3.text = "Icecube:\n" + " 'Ice Magic' + 'Third Form' + 'Attack'";
        spellBookBackground.material = iceMaterial;
        descriptionBackground1.material = iceMaterial;
        descriptionBackground2.material = iceMaterial;
        descriptionBackground3.material = iceMaterial;
    }
    
    public void VoidDescription()
    {
        spellDescription1.text = "Void Ball:\n" + " 'Void Magic' + 'First Form' + 'Attack'";
        spellDescription2.text = "Dark Slash:\n" + " 'Void Magic' + 'Second Form' + 'Attack'";
        spellDescription3.text = "Blackhole:\n" + " 'Void Magic' + 'Third Form' + 'Attack'";
        spellBookBackground.material = voidMaterial;
        descriptionBackground1.material = voidMaterial;
        descriptionBackground2.material = voidMaterial;
        descriptionBackground3.material = voidMaterial;
    }

    public void ResetBackground()
    {
        spellBookBackground.material = basicBackgroundMaterial;
        descriptionBackground1.material = basicDescriptionBackgroundMaterial;
        descriptionBackground2.material = basicDescriptionBackgroundMaterial;
        descriptionBackground3.material = basicDescriptionBackgroundMaterial;
        spellDescription1.text = " ";
        spellDescription2.text = " ";   
        spellDescription3.text = " ";   
    }
}
