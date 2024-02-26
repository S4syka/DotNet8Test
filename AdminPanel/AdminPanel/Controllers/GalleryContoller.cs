using Domain.DTOs;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class GalleryController : Controller
{
    private readonly IGalleryRepository _galleryRepository;

    public GalleryController(IUnitOfWork unitOfWork)
    {
        _galleryRepository = unitOfWork.GalleryRepo();
    }

    public ActionResult Index()
    {
        var galleries = _galleryRepository.Load();
        return View(galleries);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Gallery gallery)
    {
        _galleryRepository.Create(gallery);
        return RedirectToAction("Index");
    }

    public ActionResult Edit(Guid id)
    {
        var gallery = _galleryRepository.Read(id);
        return View(gallery);
    }

    [HttpPost]
    public ActionResult Edit(Gallery gallery)
    {
        _galleryRepository.Update(gallery);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(Guid id)
    {
        _galleryRepository.Delete(id);
        return RedirectToAction("Index");
    }
}
