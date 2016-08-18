System.register(['angular2/router'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var router_1;
    var AppRoute;
    return {
        setters:[
            function (router_1_1) {
                router_1 = router_1_1;
            }],
        execute: function() {
            AppRoute = (function () {
                function AppRoute() {
                }
                AppRoute = __decorate([
                    router_1.RouteConfig([
                        { path: '', component: null },
                        { path: 'list', component: null }
                    ]), 
                    __metadata('design:paramtypes', [])
                ], AppRoute);
                return AppRoute;
            }());
            exports_1("AppRoute", AppRoute);
        }
    }
});
