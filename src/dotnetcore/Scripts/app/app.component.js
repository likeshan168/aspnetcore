System.register(['angular2/core', 'angular2/router'], function(exports_1, context_1) {
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
    var core_1, router_1;
    var AppComponent, Hello;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (router_1_1) {
                router_1 = router_1_1;
            }],
        execute: function() {
            AppComponent = (function () {
                function AppComponent() {
                    this.title = "tour of Heros";
                    //hero: Hello = { id: 1, name: "windstorm" }
                    this.heros = [{ id: 1, name: 'andy' }, { id: 2, name: "jack" }, { id: 3, name: "baba" }, { id: 4, name: "lucky" }];
                }
                AppComponent = __decorate([
                    core_1.Component({
                        selector: 'angularjs2Demo',
                        //    template: `<h1>
                        //    {{title}}
                        //</h1>
                        //<h2>
                        //    {{hero.name}} Details
                        //</h2>
                        //<div>
                        //    <label>id:</label>{{hero.id}}
                        //    <label>name:</label> <input type="text" name="name" value="{{hero.name}}" placeholder="name"/>
                        //</div>
                        //              `,
                        templateUrl: "../views/indexPart.html",
                        directives: [router_1.ROUTER_DIRECTIVES]
                    }), 
                    __metadata('design:paramtypes', [])
                ], AppComponent);
                return AppComponent;
            }());
            exports_1("AppComponent", AppComponent);
            Hello = (function () {
                function Hello() {
                }
                return Hello;
            }());
            exports_1("Hello", Hello);
        }
    }
});
