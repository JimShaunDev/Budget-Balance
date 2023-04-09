import { Component, Input } from '@angular/core';
import { faScaleUnbalanced } from '@fortawesome/free-solid-svg-icons';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent {
  faIcon = faScaleUnbalanced;

  constructor(private router: Router) {}

  navigateMenu(link: string) {
    console.log(link);
    this.router.navigate([link]);
  }
}
