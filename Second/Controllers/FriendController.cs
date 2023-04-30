using Microsoft.Ajax.Utilities;
using Second.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Second.Controllers
{
    public class FriendController : Controller
    {

        List<Friend> friends;

        public async Task Index() // ViewResult 
        {
            friends = new List<Friend> {
                new Friend { FriendID = 1, FriendName = "Slava", Place = "Kiev" },
                new Friend { FriendID = 2, FriendName = "Adnrii", Place = "Kiev" },
                new Friend { FriendID = 3, FriendName = "Toxa", Place = "Kiev" },
                new Friend { FriendID = 4, FriendName = "Sasha", Place = "Kiev" },
                new Friend { FriendID = 5, FriendName = "Yra", Place = "Kiev" },
                new Friend { FriendID = 6, FriendName = "Test", Place = "Kiev" }
                };
        }

        public ActionResult View()
        {
            Index();
            return View(friends);
        }
        public ActionResult Edit(int id = 0, string name = "", string place = "")
        {
            Index();
            var itemToShow = friends.IndexOf(friends.Single(r => r.FriendID == id));
            if ((id !=0 )&((name != "")|(place !="")))
            {
                friends[itemToShow].FriendName = name;
                friends[itemToShow].Place = place;  
            }

            var friend = friends[itemToShow];

                return View(friend);
        }
        public ActionResult AddRecord(Friend friend)
        {
                Index();
            if (ModelState.IsValid) { 
                if (friend.FriendID > 0)
                    friends.Add(friend);
            }
            return View(friends);
        }
        public ActionResult Delete(int id)
        {
            Index();
            var itemToRemove = friends.Single(r => r.FriendID == id);
            friends.Remove(itemToRemove);
            return View(friends);
        }
    }
}