using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PrintName : MonoBehaviour
{
    void Start()
    {
        XRGrabInteractable xRGrabInteractable = new XRGrabInteractable();
        xRGrabInteractable = this.GetComponent<XRGrabInteractable>();
        xRGrabInteractable.hoverEntered.AddListener(OnRayHoverEnter);
    }


    void OnRayHoverEnter(HoverEnterEventArgs args)
    {
        var attach = args.interactableObject.GetAttachTransform(args.interactorObject);
        Debug.Log("ÐüÍ£½øÈë" + attach.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
