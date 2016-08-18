import {Component} from 'angular2/core';
import {ROUTER_DIRECTIVES} from 'angular2/router';
@Component({
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
    directives: [ROUTER_DIRECTIVES],
    styleUrls:''
})


export class AppComponent {
    title = "tour of Heros";
    //hero: Hello = { id: 1, name: "windstorm" }
    heros: Hello[] = [{ id: 1, name: 'andy' }, { id: 2, name: "jack" }, { id: 3, name: "baba" }, {id:4, name:"lucky"}];
}

export class Hello {
    id: number;
    name: string;
}
