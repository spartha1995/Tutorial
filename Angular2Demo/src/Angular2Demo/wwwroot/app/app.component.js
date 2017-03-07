"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var AppComponent = (function () {
    function AppComponent(http) {
        var _this = this;
        this.http = http;
        this.text_decoration = "";
        this.showToolTip = false;
        this.name = 'Angular';
        this.isShown = true;
        this.employee = new Employee();
        this.employees = new Array();
        this.http.get("http://localhost:5000/api/Employees").subscribe(function (x) {
            _this.employees = x.json();
        });
    }
    AppComponent.prototype.onClick = function () {
        var _this = this;
        this.http.post("http://localhost:5000/api/Employees", this.employee).subscribe(function (x) {
            _this.employees.push(x.json());
        });
    };
    AppComponent.prototype.onFilter = function (searchString) {
        var _this = this;
        this.http.get("http://localhost:5000/api/Employees/search?name=" + searchString).subscribe(function (x) {
            _this.employees = x.json();
        });
    };
    AppComponent.prototype.onDelete = function (emp) {
        var _this = this;
        this.http.delete("http://localhost:5000/api/Employees/" + emp.Id).subscribe(function (x) {
            _this.employees.splice(_this.employees.indexOf(emp), 1);
        });
    };
    AppComponent.prototype.onEdit = function (emp) {
        this.isShown = false;
        //varName = EXP?<True>:<False>
        this.employee = emp;
    };
    AppComponent.prototype.onUpdate = function () {
        var _this = this;
        this.http.put("http://localhost:5000/api/Employees/" + this.employee.Id, this.employee).subscribe(function (x) {
            _this.isShown = true;
            _this.employee = new Employee();
        });
    };
    return AppComponent;
}());
AppComponent = __decorate([
    core_1.Component({
        selector: 'my-app',
        templateUrl: '../app/app.html',
    }),
    __metadata("design:paramtypes", [http_1.Http])
], AppComponent);
exports.AppComponent = AppComponent;
var Employee = (function () {
    function Employee() {
    }
    return Employee;
}());
//# sourceMappingURL=app.component.js.map