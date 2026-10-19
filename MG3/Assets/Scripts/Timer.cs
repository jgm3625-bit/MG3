using System.Runtime.CompilerServices;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float testFloat;
    public int testInt;
    public bool testBool;
    public string testString;

    // STEP 1 -----------------------------------------------------------------
    // Uncomment the lines and fill in the ???s to add one member variable to
    //      the Timer class here.
    // This variable needs a type and a name.
    // It will be a decimal number to keep track of how much time we have left.
    //
    // Make sure to TUNE this value in the INSPECTOR after you create it!

    private float timeLeft;

    // STEP 1 -----------------------------------------------------------------

    // STEP 2 -----------------------------------------------------------------
    // Uncomment the below lines and fill in the ???s to create this method.
    //
    // This method will be used to start the timer's countdown.
    //
    // For input, it needs a number to represent the amount of time the countdown
    //      should start with.
    // It does not have any output.
    // 
    public void BeginTimer(float startTime)
    {
        timeLeft = startTime;

    }

    // STEP 2 -----------------------------------------------------------------

    // STEP 3 -----------------------------------------------------------------
    // Uncomment the line below and fill in the ???s to create this method.
    //
    // In this method, we will subtract the amount of time that has passed from
    //      our timer variable EVERY FRAME.
    // This is how we keep track of time.
    //
    // The method's name is a built-in one from Unity that runs EVERY FRAME.
    // It has no input or output.
    //
    private void Update()
    {
        // Time.deltaTime is a variable provided to us by Unity that represents
        //      how much time has passed since the last frame.
        // In this method body, use Time.deltaTime to decrease the the value of 
        //      our timer member variable every frame.
        timeLeft -= Time.deltaTime;

    }

    // This method can be used to check the value of your time member variable.
    public float GetTimeLeft()
    {
        // STEP 4 -------------------------------------------------------------
        // REPLACE this line with a new line of code that reutrns the value of
        //      your time member variable.
        return timeLeft;
        // STEP 4 -------------------------------------------------------------
    }

    // STEP 5 -----------------------------------------------------------------
    // Write a method here named IsFinished that RETURNS TRUE IF our time member
    //      variable is out of time.
    // Other classes can CALL this method to check if the timer is up.
    // It should be public, and has no input.
    public bool IsFinished ()
    {
        return timeLeft <= 0;
    }

    // STEP 5 -----------------------------------------------------------------
}