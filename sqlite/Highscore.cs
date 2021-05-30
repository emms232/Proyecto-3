﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Highscore 
{
    public int Score { get; set; }

    public string Name { get; set; }

    public int ID { get; set; }

    public Highscore(int id, int score, string name)
    {
        this.Score = score;
        this.Name = name;
        this.ID = id;

    }
}
