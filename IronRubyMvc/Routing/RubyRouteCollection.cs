﻿namespace IronRubyMvc {
    using System.Collections;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RubyRouteCollection {
        RouteCollection routes;

        public RubyRouteCollection(RouteCollection routes) {
            this.routes = routes;
        }

        public void MapRoute(string name, string url) {
            MapRoute(name, url, new Hashtable(), new Hashtable());
        }

        public void MapRoute(string name, string url, IDictionary defaults) {
            MapRoute(name, url, defaults, new Hashtable());
        }

        public void MapRoute(string name, string url, IDictionary defaults, IDictionary constraints) {
            routes.Add(name, new Route(url, new MvcRouteHandler()) {
                Defaults = defaults.ToRouteDictionary(),
                Constraints = constraints.ToRouteDictionary()
            });
        }
    }
}