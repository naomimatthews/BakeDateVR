using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


    public class TwoHandGrabInteractable : XRGrabInteractable
    {
        public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();

        void Start()
        {
            foreach (var item in secondHandGrabPoints)
            {
                item.onSelectEnter.AddListener(OnSecondHandGrab);
                item.onSelectExit.AddListener(OnSecondHandRelease);
        }
        }

        public void OnSecondHandGrab(XRBaseInteractor interactor)
        {
            Debug.Log("second hand grab");
        }

        public void OnSecondHandRelease(XRBaseInteractor interactor)
        {
            Debug.Log("second hand release");
        }

        protected override void OnSelectEnter(XRBaseInteractor interactor)
        {
            Debug.Log("first grab enter");
            base.OnSelectEnter(interactor);
        }

        protected override void OnSelectExit(XRBaseInteractor interactor)
        {
             Debug.Log("first grab exit");
            base.OnSelectExit(interactor);
        }

        public override bool IsSelectableBy(XRBaseInteractor interactor)
        {
            bool isAlreadyGrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
            return base.IsSelectableBy(interactor);
        }
    }

