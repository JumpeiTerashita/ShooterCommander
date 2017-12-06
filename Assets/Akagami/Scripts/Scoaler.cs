using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Scoaler{
    public static float score = 0;
	public static void plusScore(float _plusCount)
    {
        score += _plusCount;
    }
    public static float getScore()
    {
        return score;
    }
    public static void initScore()
    {
        score = 0;
    }
}
