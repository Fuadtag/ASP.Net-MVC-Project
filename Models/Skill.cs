﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}