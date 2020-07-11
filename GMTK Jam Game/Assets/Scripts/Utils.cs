using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bounds2D
{
    public Vector2[] boundSets = new Vector2[2];

    public Vector2 this[int index]
    {
        get
        {
            index = index > 1 ? 1 : index < 0 ? 0 : index;
            return boundSets[index];
        }
        set
        {
            index = index > 1 ? 1 : index < 0 ? 0 : index;
            boundSets[index] = value;
        }
    }

    public static Vector2 operator*(Vector2 a, Bounds2D b)
    {
        Vector2 result = new Vector2(0, 0);
        for (int i = 0; i < 2; i++)
        {
            if (a[i] < 0)
            {
                result[i] = a[i] * -b[i][0];
            }
            else
            {
                result[i] = a[i] * b[i][1];
            }
        }
        return result;
    }

    public static Vector2 operator*(Bounds2D b, Vector2 a)
    {
        return a * b;
    }
}

[System.Serializable]
public struct Timer
{
    public bool looping;
    public float currentTime;
    public float maxTime;

    public Timer(float maxTime = 1, bool looping = false)
    {
        this.maxTime = maxTime;
        this.looping = looping;
        currentTime = 0;
    }

    public void Update(float deltaTime)
    {
        if (!IsExpired())
        {
            currentTime += deltaTime;
        }
        else if(looping)
        {
            currentTime -= maxTime;
        }
    }

    public bool IsExpired()
    {
        return currentTime >= maxTime;
    }

    public void Reset()
    {
        currentTime = 0;
    }
}