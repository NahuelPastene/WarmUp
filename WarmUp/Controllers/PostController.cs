using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarmUp.Model;
using WarmUp.Repository;

namespace WarmUp.Controllers
{
    public class PostController : Controller
    {
        private readonly PostRepository _postRepository;
        public PostController(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Detail(int Id)
        {
            var post = _postRepository.GetById(Id);
            return View(post);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            post.CreateDate = DateTime.UtcNow;
            post.Active = true;
            post = _postRepository.Create(post);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Delete(int Id)
        {
            var post = _postRepository.GetById(Id);
            _postRepository.Delete(post);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var post = _postRepository.GetById(Id);
            _postRepository.Edit(post);
            return View("Edit", post);
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            _postRepository.Edit(post);
            return RedirectToAction("Index", "Home");
        }
    }
}
