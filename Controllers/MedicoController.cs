using Microsoft.AspNetCore.Mvc;
using Unidades_De_Saude.Data.Entities;
using Unidades_De_Saude.ModelViewModel;
using Unidades_De_Saude.Repositories;

namespace Unidades_De_Saude.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicoRepository _medicoRepository;

        #region Construtor
        public MedicoController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        #endregion

        #region Actions
        public IActionResult Index()
        {
            var medicos = _medicoRepository.GetAll();
            MedicoViewModel model = new MedicoViewModel();
            return View(model.GetListDatabase(medicos.ToList()));
        }
        public IActionResult EspecialidadesIndex()
        {
            EspecialidadesViewModel especialidades = new EspecialidadesViewModel();
            var objs = _medicoRepository.GetEspecialidades();

            return View(especialidades.GetListDatabase(objs));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MedicoViewModel model)
        {
            if (ModelState.IsValid)
            {
                Medico medico = new Medico();
                model.UpdateDatabse(medico);
                _medicoRepository.Add(medico);
            }
            return RedirectToAction("Index");
        }


        public IActionResult CreateEspecialidade()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEspecialidade(EspecialidadesViewModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Especialidades especialidade = new Especialidades();
                    model.UpdateDatabse(especialidade);
                    _medicoRepository.AddEspecialidade(especialidade);
                }
            }catch (Exception ex)
            {
                
            }
            return RedirectToAction("EspecialidadesIndex");
        }

        public IActionResult EditEspecialidade(int id)
        {
            EspecialidadesViewModel model = new EspecialidadesViewModel();
            var especialidade = _medicoRepository.GetEspecialidade(id);

            model.GetDatabase(especialidade);

            return View(model);
        }

        #endregion
    }
}
