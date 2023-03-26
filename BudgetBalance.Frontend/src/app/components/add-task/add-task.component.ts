import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Task } from 'src/app/Task';
import { UiService } from 'src/app/services/ui.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css'],
})
export class AddTaskComponent implements OnInit {
  @Output() onAddTask: EventEmitter<Task> = new EventEmitter();

  title: string;
  dueDate: string;
  reminder: boolean;
  showAddTask: boolean;
  subscription: Subscription;

  constructor(private uiService: UiService) {
    this.subscription = this.uiService
      .onToggle()
      .subscribe((value) => (this.showAddTask = value));
  }

  ngOnInit(): void {}
  onSubmit() {
    if (!this.title) {
      alert('Title is required!');
    }

    const newTask = {
      title: this.title,
      dueDate: this.dueDate,
      reminder: this.reminder,
    };

    //do
    this.onAddTask.emit(newTask);

    this.title = '';
    this.dueDate = '';
    this.reminder = false;
  }
}
