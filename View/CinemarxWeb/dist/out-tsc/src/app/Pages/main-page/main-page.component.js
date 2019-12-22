import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Validators } from '@angular/forms';
let MainPageComponent = class MainPageComponent {
    constructor(formBuilder) {
        this.formBuilder = formBuilder;
        this.numSlide = 0;
        this.correctLogIn = false;
        this.slide = [new SlideInfo('The Irishman', '10', '../../assets/Images/ImgForPresentationPage/Slides/the-irishman.jpg', 16, 0),
            new SlideInfo('Joker', '9.8', '../../assets/Images/ImgForPresentationPage/Slides/JokerFIlm.jpg', 18, 1),
            new SlideInfo('Parasites', '8.1', '../../assets/Images/ImgForPresentationPage/Slides/1189411.jpg', 16, 2),
            new SlideInfo('Downton Abbey', '7.7', '../../assets/Images/ImgForPresentationPage/Slides/downton-abbey.jpg', 20, 3),
            new SlideInfo('RAMBO: last blood', '7.3', '../../assets/Images/ImgForPresentationPage/Slides/1*_thZ3hVed8XakCZe7Lua_Q.jpeg', 14, 4)];
        this.newFilms =
            [[new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 3D, 4DX', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 4DX', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '30+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '8+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%')],
                [new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('', '../../assets/Images/ImgForPresentationPage/NewFilms/add.png', '', '', '', 'Побачити більше')]];
        this.displayFilmsScope = [0, 1];
        this.allFilms =
            [[new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 3D, 4DX', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 4DX', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '30+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '8+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%')],
                [new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                ],
                [new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                    new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
                ]];
    }
    ngOnInit() {
        setTimeout(() => this.slideAnimation(), 100);
        this.registerForm = this.formBuilder.group({
            email: [null, [Validators.required, Validators.minLength(4), Validators.email]],
            password: [null, [Validators.required, Validators.minLength(4),
                    Validators.pattern(/(?=^.{4,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$/u)]],
            retryPassword: [null, [Validators.required, Validators.minLength(4)]]
        });
        this.loginForm = this.formBuilder.group({
            email: [null, [Validators.required, Validators.minLength(4), Validators.email]],
            password: [null, [Validators.required, Validators.minLength(4),
                    Validators.pattern(/(?=^.{4,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$/u)]]
        });
    }
    onFormSubmit(form) {
        alert('It is FAIL!');
    }
    nextPage() {
        const rightArrow = document.getElementsByClassName('rightArrow')[0];
        const leftArrow = document.getElementsByClassName('leftArrow')[0];
        if (this.allFilms.length > (this.displayFilmsScope[1] + 2)) {
            this.displayFilmsScope = [this.displayFilmsScope[0] + 1, this.displayFilmsScope[1] + 1];
            leftArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
            leftArrow.style.cursor = 'pointer';
        }
        else if (this.allFilms.length > (this.displayFilmsScope[1] + 1) && this.allFilms.length <= (this.displayFilmsScope[1] + 2)) {
            this.displayFilmsScope = [this.displayFilmsScope[1] + 1];
            leftArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
            leftArrow.style.cursor = 'pointer';
        }
        else {
            /* alert(this.allFilms.length + '>' + (this.displayFilmsScope[1] + 1) +
              '&&' + this.allFilms.length + '<' + (this.displayFilmsScope[1] + 2)); */
        }
        if (this.displayFilmsScope.length === 1 || this.allFilms.length <= (this.displayFilmsScope[1] + 1)) {
            rightArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowGrey.png';
            rightArrow.style.cursor = 'default';
            rightArrow.style.disabled = true;
        }
    }
    previousPage() {
        const rightArrow = document.getElementsByClassName('rightArrow')[0];
        const leftArrow = document.getElementsByClassName('leftArrow')[0];
        if (this.displayFilmsScope[0] !== 0 && this.displayFilmsScope.length !== 1) {
            this.displayFilmsScope = [this.displayFilmsScope[0] - 1, this.displayFilmsScope[1] - 1];
            rightArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
            rightArrow.style.cursor = 'pointer';
        }
        else if (this.displayFilmsScope[0] !== 0 && this.displayFilmsScope.length === 1) {
            this.displayFilmsScope = [this.displayFilmsScope[0] - 2, this.displayFilmsScope[0] - 1];
            rightArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
            rightArrow.style.cursor = 'pointer';
        }
        if (this.displayFilmsScope[0] === 0) {
            leftArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowGrey.png';
            leftArrow.style.cursor = 'default';
            leftArrow.style.disabled = true;
        }
    }
    mathRound(num) {
        return Math.round(num);
    }
    changeSlide(num) {
        const slides = [];
        const slideCircle = [];
        for (let i = 0; i < 5; i++) {
            slides[i] = document.getElementsByClassName('Slide')[i];
            slides[i].style.opacity = '0';
            slides[i].style.zIndex = '1';
            slides[i].style.transform = 'translateX(0)';
            slides[i].style.cursor = 'default';
            slideCircle[i] = document.getElementsByClassName('crcl')[i];
            // slideCircle[i].style.borderColor = 'black';
            slideCircle[i].style.border = 'solid 1px black';
        }
        // slideCircle[num].style.borderColor = 'white';
        slideCircle[num].style.border = 'solid 4px black';
        if (num === 0) {
            slides[4].style.transform = 'translateX(-102%)';
            slides[4].style.opacity = '0.5';
            slides[4].style.cursor = 'pointer';
            slides[num + 1].style.transform = 'translateX(102%)';
            slides[num + 1].style.opacity = '0.5';
            slides[num + 1].style.cursor = 'pointer';
            slides[num].style.transform = 'translateX(0)';
            slides[num].style.opacity = '1';
            slides[num].style.zIndex = '5';
        }
        else if (num === 4) {
            slides[num - 1].style.transform = 'translateX(-102%)';
            slides[num - 1].style.opacity = '0.5';
            slides[num - 1].style.cursor = 'pointer';
            slides[0].style.transform = 'translateX(102%)';
            slides[0].style.opacity = '0.5';
            slides[0].style.cursor = 'pointer';
            slides[num].style.transform = 'translateX(0)';
            slides[num].style.opacity = '1';
            slides[num].style.zIndex = '5';
        }
        else {
            slides[num - 1].style.transform = 'translateX(-102%)';
            slides[num - 1].style.opacity = '0.5';
            slides[num - 1].style.cursor = 'pointer';
            slides[num + 1].style.transform = 'translateX(102%)';
            slides[num + 1].style.opacity = '0.5';
            slides[num + 1].style.cursor = 'pointer';
            slides[num].style.transform = 'translateX(0)';
            slides[num].style.opacity = '1';
            slides[num].style.zIndex = '5';
        }
        this.numSlide = num;
    }
    slideAnimation() {
        if (this.numSlide === 5) {
            this.numSlide = 0;
        }
        this.changeSlide(this.numSlide);
        ++this.numSlide;
        setTimeout(() => this.slideAnimation(), 5000);
    }
    registerShowWindow(condition) {
        const regWindow = document.getElementsByClassName('registration')[0];
        const regWindowInput = [document.getElementsByClassName('regInputField')[0],
            document.getElementsByClassName('regInputField')[1],
            document.getElementsByClassName('regInputField')[2]];
        if (condition) {
            regWindowInput[0].value = '';
            regWindowInput[1].value = '';
            regWindowInput[2].value = '';
            regWindow.style.display = 'flex';
        }
        else {
            regWindow.style.display = 'none';
        }
    }
    loginShowWindow(condition) {
        const logWindow = document.getElementsByClassName('login')[0];
        const logWindowInput = [document.getElementsByClassName('logInputField')[0],
            document.getElementsByClassName('logInputField')[1]];
        if (condition) {
            logWindowInput[0].value = '';
            logWindowInput[1].value = '';
            logWindow.style.display = 'flex';
        }
        else {
            logWindow.style.display = 'none';
        }
    }
};
MainPageComponent = tslib_1.__decorate([
    Component({
        selector: 'app-main-page',
        templateUrl: './main-page.component.html',
        styleUrls: ['./main-page.component.css']
    })
], MainPageComponent);
export { MainPageComponent };
export class SlideInfo {
    constructor(filmName, imdb, img, age, num) {
        this.filmName = filmName;
        this.imdb = imdb;
        this.img = img;
        this.age = age;
        this.num = num;
    }
}
export class NewFilms {
    constructor(name, img, technologies, age, discount, desc = '') {
        this.name = name;
        this.img = img;
        this.technologies = technologies;
        this.age = age;
        this.discount = discount;
        this.desc = desc;
    }
}
//# sourceMappingURL=main-page.component.js.map