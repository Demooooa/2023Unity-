using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable xRGrabInteractable = new XRGrabInteractable();
        xRGrabInteractable = this.GetComponent<XRGrabInteractable>();
        xRGrabInteractable.selectEntered.AddListener(OnRaySelect);
    }


    void OnRaySelect(SelectEnterEventArgs args)
    {
        var attach = args.interactableObject.GetAttachTransform(args.interactorObject);
        Material m=attach.gameObject.GetComponent<Renderer>().material;
        m.color = Color.red;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
