using System;
using System.Collections.Generic;
using System.Linq;
using esubmanager.common;
using esubmanager.model;
using esubmanager.hydrate;

namespace esubmanager.dispatcher
{
    public class DispatchStorage : IGetChildrenRequestService<HydratedTree, IDispatchedStorageRequest>
    {
        private readonly List<Pattern> _rules;

        public DispatchStorage()
        {
            _rules = new List<Pattern>
            {
                new Pattern
                {
                    Predicate = e => e is CifsStorage,
                    Activator = r => new CifsGetChildrenRequest(r)
                },
                new Pattern
                {
                    Predicate = e => e is EctdStorage,
                    Activator = r => new EctdManagerGetChildrenRequest(r)
                }
            };
        }

        public IDispatchedStorageRequest Handle(HydratedTree request)
        {
            foreach(var r in _rules)
            {
                if (request.ParentElement.Any(r.Predicate))
                {
                    return r.Activator(request);
                }
            }
            throw new NotImplementedException();
        }

        private struct Pattern
        {
            public Func<ITreeElement, bool> Predicate;
            public Func<HydratedTree, IDispatchedStorageRequest> Activator;
        }
    }
}