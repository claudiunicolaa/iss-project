﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Section
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public User SectionLeader { get; set; }
        public IList<Topic> Topics { get; set; }
        public IList<User> Listeners { get; set; }
        public IList<User> Authors { get; set; }
        public IList<Proposal> Proposals { get; set; }
        public string Room { get; set; }

        public Section()
        {
            Name = "";
            SectionLeader = new User();
            Topics = new List<Topic>();
            Listeners = new List<User>();
            Authors = new List<User>();
            Room = "";
        }

        public Section(
            string name,
            User sectionLeader,
            IList<Topic> topics,
            IList<User> listeners,
            IList<User> authors,
            string room
        )
        {
            Name = name;
            SectionLeader = sectionLeader;
            Topics = topics;
            Listeners = listeners;
            Authors = authors;
            Room = room;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
