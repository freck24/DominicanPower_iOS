//
// Fingers Gestures
// (c) 2015 Digital Ruby, LLC
// Source code may be used for personal or commercial projects.
// Source code may NOT be redistributed or sold.
// 

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRubyShared
{
    public class DemoScriptSwipe : MonoBehaviour
    {

        [Tooltip("Set the required touches for the swipe.")]
        [Range(1, 10)]
        public int SwipeTouchCount = 1;

        [Tooltip("Controls how the swipe gesture ends. See SwipeGestureRecognizerSwipeMode enum for more details.")]
        public SwipeGestureRecognizerEndMode SwipeMode = SwipeGestureRecognizerEndMode.EndImmediately;


        private SwipeGestureRecognizer swipe;

        private void Start()
        {
            swipe = new SwipeGestureRecognizer();
            swipe.StateUpdated += Swipe_Updated;
            swipe.DirectionThreshold = 0;
            swipe.MinimumNumberOfTouchesToTrack = swipe.MaximumNumberOfTouchesToTrack = SwipeTouchCount;
           // swipe.PlatformSpecificView = Image;
            FingersScript.Instance.AddGesture(swipe);
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.StateUpdated += Tap_Updated;
            FingersScript.Instance.AddGesture(tap);
        }

        private void Update()
        {
            swipe.MinimumNumberOfTouchesToTrack = swipe.MaximumNumberOfTouchesToTrack = SwipeTouchCount;
            swipe.EndMode = SwipeMode;
        }

        private void Tap_Updated(DigitalRubyShared.GestureRecognizer gesture)
        {
            if (gesture.State == GestureRecognizerState.Ended)
            {
                Debug.Log("Tap");
                PlayerRunner.pr.sendedTap = true;
            }
        }

        private void Swipe_Updated(DigitalRubyShared.GestureRecognizer gesture)
        {
         //   Debug.LogFormat("Swipe state: {0}", gesture.State);

            SwipeGestureRecognizer swipe = gesture as SwipeGestureRecognizer;
            if (swipe.State == GestureRecognizerState.Ended)
            {
                float angle = Mathf.Atan2(-swipe.DistanceY, swipe.DistanceX) * Mathf.Rad2Deg;
                Debug.LogFormat("Swipe dir: {0}", swipe.EndDirection);

                if (swipe.EndDirection == SwipeGestureRecognizerDirection.Right) PlayerRunner.pr.MovePlayer(1);
                if (swipe.EndDirection == SwipeGestureRecognizerDirection.Left) PlayerRunner.pr.MovePlayer(-1);
                if (swipe.EndDirection == SwipeGestureRecognizerDirection.Up) print("SALTAR");
                if (swipe.EndDirection == SwipeGestureRecognizerDirection.Down) print("AGACHARSE");

            }
        }


        public void derecha()
        {
            PlayerRunner.pr.MovePlayer(1);
        } public void izquierda()
        {
            PlayerRunner.pr.MovePlayer(-1);
        }
    }
}