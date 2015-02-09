using DemoAspNetMvc01.Domain.Model;
using DemoAspNetMvc01.Service.Service.Interface;
using DemoAspNetMvc01.Web.Models;
using System;
using System.Net;
using System.Web.Mvc;

namespace DemoAspNetMvc01.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;

        public PostController(IPostService postService, IUserService userService, ICategoryService categoryService)
        {
            _postService = postService;
            _userService = userService;
            _categoryService = categoryService;
        }

        // GET: Post
        //[Route("index")]
        //[Route("index/{category_id:guid}")]
        //[Route("index/{user_id:guid}")]
        public ActionResult Home()
        {
            return View(_postService.List());
        }

        public ActionResult index()
        {
            return View(_postService.List());
        }

        // GET: Post/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = _postService.GetById(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Post/Create
        //[Route("admin-create")]
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(_userService.List(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(_categoryService.List(), "Id", "Title");

            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Description,CategoryId,UserId")] PostViewModel postViewModel)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post();
                post.Id = Guid.NewGuid();
                post.Title = postViewModel.Title;
                post.Description = postViewModel.Description;
                post.CategoryId = postViewModel.CategoryId;
                post.UserId = postViewModel.UserId;

                _postService.Create(post);
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(_userService.List(), "Id", "Name", postViewModel.UserId);
            ViewBag.CategoryId = new SelectList(_categoryService.List(), "Id", "Title", postViewModel.CategoryId);

            return View(postViewModel);
        }

        // GET: Post/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = _postService.GetById(id);

            if (post == null)
            {
                return HttpNotFound();
            }

            PostViewModel postViewModel = new PostViewModel();
            postViewModel.Id = post.Id;
            postViewModel.Title = post.Title;
            postViewModel.Description = post.Description;
            postViewModel.CategoryId = post.CategoryId;
            postViewModel.UserId = post.UserId;

            ViewBag.UserId = new SelectList(_userService.List(), "Id", "Name", post.UserId);
            ViewBag.CategoryId = new SelectList(_categoryService.List(), "Id", "Title", post.CategoryId);

            return View(postViewModel);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,CategoryId,UserId")] Post postViewModel)
        {
            if (ModelState.IsValid)
            {
                Post post = _postService.GetById(postViewModel.Id);

                post.Title = postViewModel.Title;
                post.Description = postViewModel.Description;
                post.CategoryId = postViewModel.CategoryId;
                post.UserId = postViewModel.UserId;

                _postService.Update(post);

                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(_userService.List(), "Id", "Name", postViewModel.UserId);
            ViewBag.CategoryId = new SelectList(_categoryService.List(), "Id", "Title", postViewModel.CategoryId);

            return View(postViewModel);
        }

        // GET: Post/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = _postService.GetById(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Post post = _postService.GetById(id);
            _postService.Delete(post);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _postService.Dispose();

            //if (disposing)
            //{
            //    _postService.Dispose();
            //}
            //base.Dispose(disposing);
        }
    }
}
