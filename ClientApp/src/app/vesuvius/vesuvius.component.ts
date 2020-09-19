import { Component } from '@angular/core';

@Component({
  selector: 'app-vesuvius-component',
  templateUrl: './vesuvius.component.html'
})
export class VesuviusComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
