using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    public class Event_BYT 
    {

        private int _eventId;
        private string _name;
        private DateTime _start;
        private DateTime _end;

        [Required]
        public int EventId {
            get {
                return _eventId;
            }
            set {
                if (value < 0) {
                    throw new ValidationException();
                }
                _eventId = value;
            }
        }

        [Required]
        public string Name {
            get {
                return _name;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 60) {
                    throw new ValidationException();
                }
                _name = value;
            }
        }

        [Required]
        public DateTime StartDateTime {
            get {
                return _start;
            }
            set {
                if (value < DateTime.Now) { //Don't accept past dates
                    throw new ValidationException();
                }
                if (_end.Year != 1 && _end < value) { //Don't allow start to be after end
                    throw new ValidationException();
                }
                _start = value;
            }
        }

        [Required]
        public DateTime EndDateTime {
            get {
                return _end;
            }
            set {
                if (value < DateTime.Now) { //Don't accept past dates
                    throw new ValidationException();
                }

                if (_start.Year != 1 && _start > value) { //Don't allow start to be after end
                    throw new ValidationException();
                }
                _end = value;
            }
        }

        public bool IsCancelled { get; set; }
        public List<Student> Attendees { get; set; }

        public Event_BYT(int eventId, string name, DateTime start, DateTime end, bool isCancelled) {
            EventId = eventId;
            Name = name;
            StartDateTime = start;
            EndDateTime = end;
            IsCancelled = isCancelled;
        }

        public void CancelEvent() 
        { 
            this.IsCancelled = true;
        }

        public void ChangeStartTime(DateTime newDateTime) 
        {
            this.StartDateTime = newDateTime;
        }
    }
}
